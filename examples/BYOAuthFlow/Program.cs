using System;
using System.IO;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using Improbable.SpatialOS.Deployment.V1Beta1;
using Improbable.SpatialOS.Platform.Common;
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
using Improbable.Worker;
using Improbable.Worker.Alpha;
using Utils;
using Deployment = Improbable.SpatialOS.Deployment.V1Beta1.Deployment;
using Locator = Improbable.Worker.Alpha.Locator;
using LocatorParameters = Improbable.Worker.Alpha.LocatorParameters;

namespace BYOAuthFlow
{
    /// <summary>
    ///     This contains the implementation of the "Player authentication" scenario.
    ///     1. Start a cloud deployment.
    ///     2. Create a PlayerIdentityToken.
    ///     3. Verify the PlayerIdentityToken.
    ///     4. Choose a deployment that is ready for login.
    ///     5. Create a LoginToken for a selected deployment.
    ///     6. Connect to the deployment using the PlayerIdentityToken and the LoginToken.
    /// </summary>
    internal class BYOAuthScenario : ScenarioBase
    {
        /// <summary>
        ///     PLEASE REPLACE.
        ///     Your SpatialOS project name.
        ///     It should be the same as the name specified in the local project definition file (spatialos.json) used to start the local API service.
        /// </summary>
        private const string ProjectName = "platform_sdk_examples";

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The path to a valid launch configuration JSON file.
        /// </summary>
        private const string LaunchConfigFilePath = "../blank_project/default_launch.json";

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The assembly you want the cloud deployment to use.
        /// </summary>
        private const string AssemblyId = "blank_project";

        private const string LocatorServerAddress = "locator.improbable.io";
        private const int LocatorServerPort = 443;
        private const string ScenarioDeploymentTag = "bring_your_own_auth";
        private const string ScenarioWorkerType = "UnityClient";

        /// <summary>
        ///     PLEASE REPLACE.
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
        ///     PLEASE REPLACE.
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
                ProjectName = ProjectName,
                DeploymentName = DeploymentName,
                LaunchConfig = new LaunchConfig
                {
                    ConfigJson = launchConfig
                },
                AssemblyName = AssemblyId,
                Tags = {ScenarioDeploymentTag}
            }).PollUntilCompleted().GetResultOrNull();
        }

        protected override void Run()
        {
            Console.WriteLine("Creating a PlayerIdentityToken");
            var playerIdentityTokenResponse = _playerAuthServiceClient.CreatePlayerIdentityToken(
                new CreatePlayerIdentityTokenRequest
                {
                    Provider = "provider",
                    PlayerIdentifier = "player_identifier",
                    ProjectName = ProjectName
                });

            Console.WriteLine("Verifying PlayerIdentityToken");
            var decodePlayerIdentityTokenResponse = _playerAuthServiceClient.DecodePlayerIdentityToken(
                new DecodePlayerIdentityTokenRequest
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken
                });
            var playerIdentityToken = decodePlayerIdentityTokenResponse.PlayerIdentityToken;
            if (playerIdentityToken.Provider != "provider") throw new Exception("Provider not recognised.");
            if (playerIdentityToken.ProjectName != ProjectName) throw new Exception("Project not recognised.");
            if (DateTime.Now.CompareTo(playerIdentityToken.ExpiryTime.ToDateTime()) > 0) throw new Exception("PlayerIdentityToken expired.");
            
            Console.WriteLine("Choosing a deployment");
            var listDeploymentsRequest = new ListDeploymentsRequest
            {
                ProjectName = ProjectName,
                Filters = {new Filter
                {
                    TagsPropertyFilter = new TagsPropertyFilter
                    {
                        Tag = "player_auth_tag",
                        Operator = TagsPropertyFilter.Types.Operator.Equal,
    
                    },
                }}
            };
            var suitableDeployment = _deploymentServiceClient.ListDeployments(listDeploymentsRequest).First();

            Console.WriteLine("Creating a LoginToken for the selected deployment");
            var createLoginTokenResponse = _playerAuthServiceClient.CreateLoginToken(
                new CreateLoginTokenRequest
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken,
                    DeploymentId = suitableDeployment.Id.ToString(),
                    LifetimeDuration = Duration.FromTimeSpan(new TimeSpan(0, 0, 30, 0)),
                    WorkerType = ScenarioWorkerType
                });

            Console.WriteLine("Connecting to the deployment using the LoginToken and PlayerIdentityToken");
            var locatorParameters = new LocatorParameters
            {
                PlayerIdentity = new PlayerIdentityCredentials
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken,
                    LoginToken = createLoginTokenResponse.LoginToken
                }
            };
            var locator = new Locator(LocatorServerAddress, LocatorServerPort, locatorParameters);
            using (var connectionFuture = locator.ConnectAsync(new ConnectionParameters
            {
                WorkerType = ScenarioWorkerType,
                Network = {ConnectionType = NetworkConnectionType.Tcp, UseExternalIp = true}
            }))
            {
                var connFuture = connectionFuture.Get(Convert.ToUInt32(Defaults.ConnectionTimeoutMillis));
                if (!connFuture.HasValue || !connFuture.Value.IsConnected) throw new Exception("No connection or connection not established");
                Console.WriteLine($"Assigned worker ID: {connFuture.Value.GetWorkerId()}");
            }
        }

        protected override void Cleanup()
        {
            if (_deployment == null) return;
            if (_deployment.Status != Deployment.Types.Status.Running &&
                _deployment.Status != Deployment.Types.Status.Starting) return;

            Console.WriteLine("Stopping deployment");
            _deploymentServiceClient.DeleteDeployment(new DeleteDeploymentRequest
            {
                Id = _deployment.Id,
            }).PollUntilCompleted();
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