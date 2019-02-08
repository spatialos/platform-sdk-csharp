using System;
using System.IO;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using Improbable.SpatialOS.Deployment.V1Alpha1;
using Improbable.SpatialOS.Platform.Common;
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
using Improbable.Worker;
using Improbable.Worker.Alpha;
using Newtonsoft.Json;
using Utils;
using Deployment = Improbable.SpatialOS.Deployment.V1Alpha1.Deployment;
using Locator = Improbable.Worker.Alpha.Locator;
using LocatorParameters = Improbable.Worker.Alpha.LocatorParameters;

namespace CapacityLimit
{
    internal class CapacityLimitScenario : ScenarioBase
    {
        /// <summary>
        ///     PLEASE REPLACE.
        ///     Your SpatialOS project name.
        ///     It should be the same as the name specified in the local project definition file (spatialos.json) used to start the local API service.
        /// </summary>
        private const string ProjectName = "platform_sdk_examples";

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The assembly you want the cloud deployment to use.
        /// </summary>
        private const string AssemblyId = "blank_project";

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The path to a valid launch configuration JSON file.
        /// </summary>
        private const string LaunchConfigFilePath = "../blank_project/capacity_launch.json";

        private const string ScenarioWorkerType = "UnityClient";
        private const string LocatorServerAddress = "locator.improbable.io";
        private const int LocatorServerPort = 443;

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The name of the deployment.
        /// </summary>
        private static readonly string DeploymentName = $"capacity_limited_{StringUtils.Random(6)}";

        private static readonly PlatformRefreshTokenCredential CredentialWithProvidedToken =
            new PlatformRefreshTokenCredential(RefreshToken);

        private readonly DeploymentServiceClient _deploymentServiceClient =
            DeploymentServiceClient.Create(credentials: CredentialWithProvidedToken);

        private readonly PlayerAuthServiceClient _playerAuthServiceClient =
            PlayerAuthServiceClient.Create(credentials: CredentialWithProvidedToken);

        private Deployment _deployment;

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The SpatialOS refresh token for a service account or a user account.
        /// </summary>
        private static string RefreshToken =>
            Environment.GetEnvironmentVariable("IMPROBABLE_REFRESH_TOKEN") ?? "PLEASE_REPLACE_ME";

        /// <summary>
        ///     This creates a cloud deployment using a launch configuration file with a capacity limit of 2.
        /// </summary>
        protected override void Setup()
        {
            Console.WriteLine("Setting up for the scenario");
            Console.WriteLine($"Preparing a live deployment with capacity: 2, name: {DeploymentName}");
            _deploymentServiceClient.CreateDeployment(new CreateDeploymentRequest
                {
                    Deployment = new Deployment
                    {
                        ProjectName = ProjectName,
                        Name = DeploymentName,
                        LaunchConfig = new LaunchConfig
                        {
                            ConfigJson = File.ReadAllText(LaunchConfigFilePath)
                        },
                        AssemblyId = AssemblyId
                    }
                })
                .PollUntilCompleted();
        }

        /// <summary>
        ///     This contains the implementation of the "Capacity limiting" scenario.
        ///     1. Gets the currently running cloud deployment that has a capacity limit.
        ///     2. Tests that connecting more clients than the capacity limit fails.
        ///     3. Updates the deployment to increase the capacity limit.
        ///     4. Tests that additional clients are now able to connect to the deployment.
        /// </summary>
        protected override void Run()
        {
            Console.WriteLine("Finding current running deployment");
            _deployment = _deploymentServiceClient
                .ListDeployments(new ListDeploymentsRequest
                {
                    ProjectName = ProjectName,
                    DeploymentName = DeploymentName
                })
                .First(d => d.Status == Deployment.Types.Status.Running);
            Console.WriteLine($"Found deployment {_deployment.Id}");

            Console.WriteLine("Setting capacity limit to 2");
            _deployment.WorkerConnectionCapacities.Clear();
            _deployment.WorkerConnectionCapacities.Add(new WorkerCapacity
            {
                WorkerType = ScenarioWorkerType,
                MaxCapacity = 2
            });
            _deploymentServiceClient.UpdateDeployment(new UpdateDeploymentRequest {Deployment = _deployment});

            Console.WriteLine("Creating a PlayerIdentityToken");
            var playerIdentityTokenResponse = _playerAuthServiceClient.CreatePlayerIdentityToken(
                new CreatePlayerIdentityTokenRequest
                {
                    Provider = "provider",
                    PlayerIdentifier = "player_identifier",
                    ProjectName = ProjectName
                });
            Console.WriteLine(JsonConvert.SerializeObject(playerIdentityTokenResponse));

            Console.WriteLine("Creating a LoginToken for the selected deployment");
            var createLoginTokenResponse = _playerAuthServiceClient.CreateLoginToken(
                new CreateLoginTokenRequest
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken,
                    DeploymentId = _deployment.Id,
                    LifetimeDuration = Duration.FromTimeSpan(new TimeSpan(0, 0, 30, 0)),
                    WorkerType = ScenarioWorkerType
                });
            Console.WriteLine(JsonConvert.SerializeObject(createLoginTokenResponse));

            Console.WriteLine("Connecting 3 workers to the deployment. Expecting only 2 to succeed");
            var locatorParameters = new LocatorParameters
            {
                PlayerIdentity = new PlayerIdentityCredentials
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken,
                    LoginToken = createLoginTokenResponse.LoginToken
                }
            };
            var locator = new Locator(LocatorServerAddress, LocatorServerPort, locatorParameters);
            for (var i = 0; i < 3; i++)
            {
                var connectionSucceeded = TryConnectWorker(locator);
                if (!connectionSucceeded && i != 2) throw new Exception("Expected worker to connect successfully");
                if (connectionSucceeded && i == 2) throw new Exception("Expected worker to fail to connect");
            }

            Console.WriteLine("Increasing capacity limit to 3");
            _deployment.WorkerConnectionCapacities.Clear();
            _deployment.WorkerConnectionCapacities.Add(new WorkerCapacity
            {
                WorkerType = ScenarioWorkerType,
                MaxCapacity = 3
            });
            _deploymentServiceClient.UpdateDeployment(new UpdateDeploymentRequest {Deployment = _deployment});

            Console.WriteLine("Connecting another worker");
            if (!TryConnectWorker(locator))
                throw new Exception("Expected worker to be able to connect after capacity increase");
        }

        protected override void Cleanup()
        {
            if (_deployment == null) return;
            if (_deployment.Status != Deployment.Types.Status.Running &&
                _deployment.Status != Deployment.Types.Status.Starting) return;

            Console.WriteLine("Stopping deployment");
            _deploymentServiceClient.StopDeployment(new StopDeploymentRequest
            {
                Id = _deployment.Id,
                ProjectName = _deployment.ProjectName
            });
        }

        private static bool TryConnectWorker(Locator locator)
        {
            using (var connectionFuture = locator.ConnectAsync(new ConnectionParameters
            {
                WorkerType = ScenarioWorkerType,
                Network = {ConnectionType = NetworkConnectionType.Tcp, UseExternalIp = true}
            }))
            {
                var connFuture = connectionFuture.Get(Convert.ToUInt32(Defaults.ConnectionTimeoutMillis));
                if (!connFuture.HasValue || !connFuture.Value.IsConnected) return false;

                Console.WriteLine($"Worker connected and assigned worker ID: {connFuture.Value.GetWorkerId()}");
                return true;
            }
        }
    }

    internal class Program
    {
        private static readonly ScenarioBase Scenario = new CapacityLimitScenario();

        private static void Main(string[] args)
        {
            Scenario.Execute();
        }
    }
}