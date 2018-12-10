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
        private const string ProjectName = "platform_sdk_examples";

        private const string AssemblyId = "blank_project";

        private const string LaunchConfigWithNoLimits = "../blank_project/default_launch.json";
        private const string LaunchConfigWithLimits = "../blank_project/capacity_launch.json";

        private const string ScenarioWorkerType = "UnityClient";
        private const string LocatorServerAddress = "locator.improbable.io";
        private const int LocatorServerPort = 443;

        private static readonly string DeploymentNameWithLimits = $"capacity_limited_test";
        private static readonly string DeploymentNameWithNoLimits = $"no_limit_test_3";

        private static readonly PlatformRefreshTokenCredential CredentialWithProvidedToken =
            PlatformRefreshTokenCredential.AutoDetected;

        private readonly DeploymentServiceClient _deploymentServiceClient =
            DeploymentServiceClient.Create(credentials: CredentialWithProvidedToken);

        private readonly PlayerAuthServiceClient _playerAuthServiceClient =
            PlayerAuthServiceClient.Create(credentials: CredentialWithProvidedToken);

        private Deployment _deploymentWithLimits;
        private Deployment _deploymentWithNoLimits;

        protected override void Setup()
        {
            Console.WriteLine("Setting up for the scenario");
            Console.WriteLine("Preparing two live deployments, one with limit, one without.");
            Console.WriteLine($"Without limits: {DeploymentNameWithNoLimits}");
            Console.WriteLine($"With limits: {DeploymentNameWithLimits}");
            
            _deploymentServiceClient.CreateDeployment(new CreateDeploymentRequest
                {
                    Deployment = new Deployment
                    {
                        ProjectName = ProjectName,
                        Name = DeploymentNameWithNoLimits,
                        LaunchConfig = new LaunchConfig
                        {
                            ConfigJson = File.ReadAllText(LaunchConfigWithNoLimits)
                        },
                        AssemblyId = AssemblyId
                    }
                })
                .PollUntilCompleted();
            
            _deploymentServiceClient.CreateDeployment(new CreateDeploymentRequest
                {
                    Deployment = new Deployment
                    {
                        ProjectName = ProjectName,
                        Name = DeploymentNameWithLimits,
                        LaunchConfig = new LaunchConfig
                        {
                            ConfigJson = File.ReadAllText(LaunchConfigWithLimits)
                        },
                        AssemblyId = AssemblyId
                    }
                })
                .PollUntilCompleted();
        }
        
        protected override void Run()
        {
            RunNoLimitCheck();
            RunWithLimitCheck();
        }

        private void RunWithLimitCheck()
        {
            Console.WriteLine(">> Testing with max capacity 2 launch deployment - ");
            Console.WriteLine("Finding the running deployment with launch limit - ");
            _deploymentWithLimits = _deploymentServiceClient
                .ListDeployments(new ListDeploymentsRequest
                {
                    ProjectName = ProjectName,
                    DeploymentName = DeploymentNameWithLimits
                })
                .First(d => d.Status == Deployment.Types.Status.Running);
            Console.WriteLine($"Found deployment {_deploymentWithLimits.Id}");
            Console.WriteLine($"Launch config: {_deploymentWithLimits.LaunchConfig}");
            Console.WriteLine($"Worker connection capacities: {_deploymentWithLimits.WorkerConnectionCapacities}");
            Console.WriteLine($"Worker connection rate limits: {_deploymentWithLimits.WorkerConnectionRateLimits}");
            
            Console.WriteLine("Making 3 connections, first two should succeed, third should fail");
            var locator = GetLocator(_deploymentWithLimits);
            Console.Write("Making connection: ");
            for (var i = 0; i < 2; i++)
            {
                Console.Write((i + 1) + ", ");
                var connectionSucceeded = TryConnectWorker(locator);
                if (!connectionSucceeded) throw new Exception("Expected worker to connect successfully");
            }
            Console.WriteLine("");
            if (TryConnectWorker(locator)) throw new Exception("Expected worker to fail to connect due to max capacity");
            
            
            Console.WriteLine("Remove max capacity and set rate limit to 15 times a minute");
            _deploymentWithLimits.WorkerConnectionCapacities.Clear();
            _deploymentWithLimits.WorkerConnectionRateLimits.Clear();
            _deploymentWithLimits.WorkerConnectionRateLimits.Add(new WorkerRateLimit
            {
                WorkerType = ScenarioWorkerType,
                Duration = new Duration {Seconds = 60},
                RequestsInDuration = 15,
            });
            _deploymentServiceClient.UpdateDeployment(new UpdateDeploymentRequest {Deployment = _deploymentWithLimits}); 
            
            Console.WriteLine("Try hit the rate limit");
            var hasBeenLimited = false;
            var count = 0;
            Console.Write("Making connection: ");
            while (!hasBeenLimited)
            {
                if (TryConnectWorker(locator))
                {
                    count++;
                    Console.Write(count + ", ");    
                }
                else
                {
                    hasBeenLimited = true;
                }
            }
            Console.WriteLine("");
            
            Console.WriteLine("Remove all limits");
            _deploymentWithLimits.WorkerConnectionRateLimits.Clear();
            _deploymentWithLimits.WorkerConnectionCapacities.Clear();
            _deploymentServiceClient.UpdateDeployment(new UpdateDeploymentRequest {Deployment = _deploymentWithLimits});
            
            Console.WriteLine("Making 20 connections, all should succeed");
            Console.Write("Making connection: ");
            for (var i = 0; i < 20; i++)
            {
                Console.Write((i+1) + ", ");
                var connectionSucceeded = TryConnectWorker(locator);
                if (!connectionSucceeded) throw new Exception("Expected worker to connect successfully");
            }
            Console.WriteLine("");
            
            Console.WriteLine(">> RunWithLimitCheck Done!!");
        }

        private void RunNoLimitCheck()
        {
            Console.WriteLine(">> Testing no limit deployment - ");
            Console.WriteLine("Finding the running no limit deployment - ");
            _deploymentWithNoLimits = _deploymentServiceClient
                .ListDeployments(new ListDeploymentsRequest
                {
                    ProjectName = ProjectName,
                    DeploymentName = DeploymentNameWithNoLimits
                })
                .First(d => d.Status == Deployment.Types.Status.Running);
            Console.WriteLine($"Found deployment {_deploymentWithNoLimits.Id}");
            Console.WriteLine($"Launch config: {_deploymentWithNoLimits.LaunchConfig}");
            Console.WriteLine($"Worker connection capacities: {_deploymentWithNoLimits.WorkerConnectionCapacities}");
            Console.WriteLine($"Worker connection rate limits: {_deploymentWithNoLimits.WorkerConnectionRateLimits}");
            
            Console.WriteLine("Making 20 connections");
            var locator = GetLocator(_deploymentWithNoLimits);
            Console.Write("Making connection: ");
            for (var i = 0; i < 20; i++)
            {
                Console.Write((i + 1) + ", ");
                var connectionSucceeded = TryConnectWorker(locator);
                if (!connectionSucceeded) throw new Exception("Expected worker to connect successfully");
            }
            Console.WriteLine("");
            
            Console.WriteLine("Set max capacity to 10");
            _deploymentWithNoLimits.WorkerConnectionCapacities.Clear();
            _deploymentWithNoLimits.WorkerConnectionCapacities.Add(new WorkerCapacity
            {
                WorkerType = ScenarioWorkerType,
                MaxCapacity = 10
            });
            _deploymentServiceClient.UpdateDeployment(new UpdateDeploymentRequest {Deployment = _deploymentWithNoLimits});
            
            Console.WriteLine("Try make another connection, should fail");
            if (TryConnectWorker(locator)) throw new Exception("Expected worker to fail to connect due to max capacity");
            
            Console.WriteLine("Remove max capacity and set rate limit to 25 times a day");
            _deploymentWithNoLimits.WorkerConnectionCapacities.Clear();
            _deploymentWithNoLimits.WorkerConnectionRateLimits.Clear();
            _deploymentWithNoLimits.WorkerConnectionRateLimits.Add(new WorkerRateLimit
            {
                WorkerType = ScenarioWorkerType,
                Duration = new Duration {Seconds = 60},
                RequestsInDuration = 25,
            });
            _deploymentServiceClient.UpdateDeployment(new UpdateDeploymentRequest {Deployment = _deploymentWithNoLimits}); 
            
            Console.WriteLine("Try hit the rate limit");
            var hasBeenLimited = false;
            var count = 0;
            Console.Write("Making connection: ");
            while (!hasBeenLimited)
            {
                if (TryConnectWorker(locator))
                {
                    count++;
                    Console.Write(count + ", ");    
                }
                else
                {
                    hasBeenLimited = true;
                }
            }
            Console.WriteLine("");
            
            Console.WriteLine("Remove all limits");
            _deploymentWithNoLimits.WorkerConnectionRateLimits.Clear();
            _deploymentWithNoLimits.WorkerConnectionCapacities.Clear();
            _deploymentServiceClient.UpdateDeployment(new UpdateDeploymentRequest {Deployment = _deploymentWithNoLimits});
            
            Console.WriteLine("Making 20 connections, all should succeed");
            Console.Write("Making connection: ");
            for (var i = 0; i < 20; i++)
            {
                Console.Write((i+1) + ", ");
                var connectionSucceeded = TryConnectWorker(locator);
                if (!connectionSucceeded) throw new Exception("Expected worker to connect successfully");
            }
            Console.WriteLine("");
            
            Console.WriteLine(">> RunNoLimitCheck Done!!");
        }

        protected override void Cleanup()
        {
            if (_deploymentWithNoLimits != null &&
                (_deploymentWithNoLimits.Status == Deployment.Types.Status.Running ||
                 _deploymentWithNoLimits.Status == Deployment.Types.Status.Starting))
            {
                Console.WriteLine("Stopping no limit deployment");
                _deploymentServiceClient.StopDeployment(new StopDeploymentRequest
                {
                    Id = _deploymentWithNoLimits.Id,
                    ProjectName = _deploymentWithNoLimits.ProjectName
                });    
            }
            
            if (_deploymentWithLimits != null &&
                (_deploymentWithLimits.Status == Deployment.Types.Status.Running ||
                 _deploymentWithLimits.Status == Deployment.Types.Status.Starting))
            {
                Console.WriteLine("Stopping with limit deployment");
                _deploymentServiceClient.StopDeployment(new StopDeploymentRequest
                {
                    Id = _deploymentWithLimits.Id,
                    ProjectName = _deploymentWithLimits.ProjectName
                });    
            }
        }

        private Locator GetLocator(Deployment deployment)
        {
            var playerIdentityTokenResponse = _playerAuthServiceClient.CreatePlayerIdentityToken(
                new CreatePlayerIdentityTokenRequest
                {
                    Provider = "provider",
                    PlayerIdentifier = "player_identifier",
                    ProjectName = ProjectName
                });
            
            var createLoginTokenResponse = _playerAuthServiceClient.CreateLoginToken(
                new CreateLoginTokenRequest
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken,
                    DeploymentId = deployment.Id,
                    LifetimeDuration = Duration.FromTimeSpan(new TimeSpan(0, 0, 30, 0)),
                    WorkerType = ScenarioWorkerType
                });

            var locatorParameters = new LocatorParameters
            {
                PlayerIdentity = new PlayerIdentityCredentials
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken,
                    LoginToken = createLoginTokenResponse.LoginToken
                }
            };
            return new Locator(LocatorServerAddress, LocatorServerPort, locatorParameters);
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