using System;
using System.IO;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using Improbable.SpatialOS.Deployment.V1Alpha1;
using Improbable.SpatialOS.Platform.Common;
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
using Improbable.Worker;
using Improbable.Worker.Alpha;
using Utils;
using Deployment = Improbable.SpatialOS.Deployment.V1Alpha1.Deployment;
using Locator = Improbable.Worker.Alpha.Locator;
using LocatorParameters = Improbable.Worker.Alpha.LocatorParameters;

namespace BYOAuthFlow
{
    /// <summary>
    ///     This contains the implementation of the "integrate your own authentication provider" scenario.
    ///     1. Start a cloud deployment.
    ///     2. Create a PlayerIdentityToken.
    ///     3. List deployments.
    ///     4. Create a LoginToken for a selected deployment.
    ///     5. Connect to the deployment using the PlayerIdentityToken and the LoginToken.
    /// </summary>
    internal class BYOAuthScenario : ScenarioBase
    {
        /// <summary>
        ///     PLEASE REPLACE ME.
        ///     Your SpatialOS project name.
        ///     It should be the same as the name specified in the local spatialos.json file used to start local API service.
        /// </summary>
        private const string ProjectName = "platform_sdk_examples";

        /// <summary>
        ///     PLEASE REPLACE ME.
        ///     The path to a valid launch configuration json file.
        /// </summary>
        private const string LaunchConfigFilePath = "../blank_project/default_launch.json";

        /// <summary>
        ///     PLEASE REPLACE ME.
        ///     The assembly you want the cloud deployment to use.
        /// </summary>
        private const string AssemblyId = "blank_project";

        private const string LocatorServerAddress = "locator.improbable.io";
        private const int LocatorServerPort = 443;
        private const string ScenarioDeploymentTag = "bring_your_own_auth";
        private const string ScenarioWorkerType = "UnityClient";

        /// <summary>
        ///     PlEASE REPLACE ME.
        ///     The name of the deployment.
        /// </summary>
        private static readonly string DeploymentName = $"byoauth_{StringUtils.Random(6)}";

        private static readonly PlatformRefreshTokenCredential CredentialWithProvidedToken =
            new PlatformRefreshTokenCredential(RefreshToken);

        private readonly DeploymentServiceClient _deploymentServiceClient =
            DeploymentServiceClient.Create(credentials: CredentialWithProvidedToken);

        private readonly PlayerAuthServiceClient _playerAuthServiceClient =
            PlayerAuthServiceClient.Create(credentials: CredentialWithProvidedToken);

        private Deployment _deployment;

        /// <summary>
        ///     PLEASE REPLACE ME.
        ///     The SpatialOS refresh token of a service account or a user account.
        /// </summary>
        private static string RefreshToken =>
            Environment.GetEnvironmentVariable("IMPROBABLE_REFRESH_TOKEN") ?? "PLEASE_REPLACE_ME";

        protected override void Setup()
        {
            Console.WriteLine($"Starting a deployment with name: {DeploymentName}");
            var launchConfig = File.ReadAllText(LaunchConfigFilePath);
            _deployment = _deploymentServiceClient.CreateDeployment(new CreateDeploymentRequest
            {
                Deployment = new Deployment
                {
                    ProjectName = ProjectName,
                    Name = DeploymentName,
                    LaunchConfig = new LaunchConfig
                    {
                        ConfigJson = launchConfig
                    },
                    AssemblyId = AssemblyId,
                    Tag = {ScenarioDeploymentTag}
                }
            }).PollUntilCompleted().GetResultOrNull();
        }

        protected override void Run()
        {
            Console.WriteLine("Create a PlayerIdentityToken");
            var playerIdentityTokenResponse = _playerAuthServiceClient.CreatePlayerIdentityToken(
                new CreatePlayerIdentityTokenRequest
                {
                    Provider = "provider",
                    PlayerIdentifier = "player_identifier",
                    ProjectName = ProjectName
                });

            Console.WriteLine("Choosing a deployment");
            var suitableDeployment = _deploymentServiceClient.ListDeployments(new ListDeploymentsRequest
            {
                ProjectName = ProjectName
            }).First(d => d.Tag.Contains(ScenarioDeploymentTag));

            Console.WriteLine("Create a LoginToken for the selected deployment");
            var createLoginTokenResponse = _playerAuthServiceClient.CreateLoginToken(
                new CreateLoginTokenRequest
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken,
                    DeploymentId = suitableDeployment.Id,
                    LifetimeDuration = Duration.FromTimeSpan(new TimeSpan(0, 0, 30, 0)),
                    WorkerType = ScenarioWorkerType
                });

            Console.WriteLine("Connect to the deployment using the LoginToken and PlayerIdentityToken");
            var locatorParameters = new LocatorParameters
            {
                PlayerIdentity = new PlayerIdentityCredentials
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken,
                    LoginToken = createLoginTokenResponse.LoginToken
                },
                UseInsecureConnection = false
            };
            var locator = new Locator(LocatorServerAddress, LocatorServerPort, locatorParameters);
            using (var connectionFuture = locator.ConnectAsync(new ConnectionParameters
            {
                WorkerType = ScenarioWorkerType,
                Network = {ConnectionType = NetworkConnectionType.Tcp, UseExternalIp = true}
            }))
            {
                var connectionOption = connectionFuture.Get(5000 /* Using milliseconds */);
                if (!connectionOption.HasValue) throw new Exception("Connection returned nothing");
                Console.WriteLine($"Assigned worker ID: {connectionOption.Value.GetWorkerId()}");
            }
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
    }

    internal class Program
    {
        private static readonly ScenarioBase Scenario = new BYOAuthScenario();

        private static void Main(string[] args)
        {
            Scenario.Execute();
        }
    }
}