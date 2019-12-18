using System;
using Google.Protobuf.WellKnownTypes;
using Improbable.SpatialOS.Deployment.V1Alpha1;
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
using Improbable.Worker;
using Improbable.Worker.Alpha;
using Newtonsoft.Json;
using Utils;
using Locator = Improbable.Worker.Alpha.Locator;
using LocatorParameters = Improbable.Worker.Alpha.LocatorParameters;

namespace CapacityLimit
{
    /// <summary>
    /// This contains the implementation of the "Capacity limiting" scenario.
    /// 1. Gets the currently running cloud deployment that has a capacity limit.
    /// 2. Tests that connecting more clients than the capacity limit fails.
    /// 3. Updates the deployment to increase the capacity limit.
    /// 4. Tests that additional clients are now able to connect to the deployment.
    /// </summary>
    internal class CapacityLimitScenario : ScenarioBase
    {
        private const string ScenarioWorkerType = "UnityClient";
        private const string LocatorServerAddress = "locator.improbable.io";
        private const int LocatorServerPort = 443;

        protected override void Run()
        {
            Console.WriteLine("Finding current running deployment");
            _deployment = _deploymentServiceClient.GetRunningDeploymentByName(ProjectName, DeploymentName).Deployment;
            Console.WriteLine($"Found deployment {_deployment.Id}");

            Console.WriteLine("Setting capacity limit to 2");
            _deploymentServiceClient.SetDeploymentWorkerCapacities(
                Convert.ToInt64(_deployment.Id),
                new WorkerCapacity[]
                {
                    new WorkerCapacity
                    {
                        WorkerType = ScenarioWorkerType,
                        MaxCapacity = 2
                    }
                }
            );

            Console.WriteLine("Creating a PlayerIdentityToken");
            var playerIdentityTokenResponse = _playerAuthServiceClient.CreatePlayerIdentityToken(ProjectName, "provider", "player_identifier");
            Console.WriteLine(JsonConvert.SerializeObject(playerIdentityTokenResponse));

            Console.WriteLine("Creating a LoginToken for the selected deployment");
            var createLoginTokenResponse = _playerAuthServiceClient.CreateLoginToken(
                new CreateLoginTokenRequest
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken,
                    DeploymentId = _deployment.Id.ToString(),
                    LifetimeDuration = Duration.FromTimeSpan(new TimeSpan(0, 0, 30, 0)),
                    WorkerType = ScenarioWorkerType
                }
            );
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
            _deploymentServiceClient.SetDeploymentWorkerCapacities(
                Convert.ToInt64(_deployment.Id),
                new WorkerCapacity[]
                {
                    new WorkerCapacity
                    {
                        WorkerType = ScenarioWorkerType,
                        MaxCapacity = 3
                    }
                }
            );

            Console.WriteLine("Connecting another worker");
            if (!TryConnectWorker(locator))
            {
                throw new Exception("Expected worker to be able to connect after capacity increase");
            }
        }

        private static bool TryConnectWorker(Locator locator)
        {
            using (var connectionFuture = locator.ConnectAsync(new ConnectionParameters
            {
                WorkerType = ScenarioWorkerType,
                Network = { ConnectionType = NetworkConnectionType.Tcp, UseExternalIp = true }
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