using System;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using Improbable.SpatialOS.Deployment.V1Alpha1;
using Improbable.SpatialOS.PlayerAuth.V2Alpha1;
using Improbable.Worker;
using Improbable.Worker.Alpha;
using Utils;
using Locator = Improbable.Worker.Alpha.Locator;
using LocatorParameters = Improbable.Worker.Alpha.LocatorParameters;

namespace BYOAuthFlow
{
    /// <summary>
    /// This contains the implementation of the "Player authentication" scenario.
    /// 1. Start a cloud deployment.
    /// 2. Create a PlayerIdentityToken.
    /// 3. Verify the PlayerIdentityToken.
    /// 4. Choose a deployment that is ready for login.
    /// 5. Create a LoginToken for a selected deployment.
    /// 6. Connect to the deployment using the PlayerIdentityToken and the LoginToken.
    /// </summary>
    internal class BYOAuthScenario : ScenarioBase
    {
        private const string LocatorServerAddress = "locator.improbable.io";
        private const int LocatorServerPort = 443;
        private const string ScenarioDeploymentTag = "bring_your_own_auth";
        private const string ScenarioWorkerType = "UnityClient";

        protected override void Run()
        {
            Console.WriteLine("Setting player_auth_tag on live deployment.");
            _deploymentServiceClient.SetDeploymentTags(Convert.ToInt64(_deployment.Id), new String[] { "player_auth_tag" });

            Console.WriteLine("Creating a PlayerIdentityToken");
            var playerIdentityTokenResponse = _playerAuthServiceClient.CreatePlayerIdentityToken(ProjectName, "provider", "player_identifier");

            Console.WriteLine("Verifying PlayerIdentityToken");
            var decodePlayerIdentityTokenResponse = _playerAuthServiceClient.DecodePlayerIdentityToken(playerIdentityTokenResponse.PlayerIdentityToken);

            var playerIdentityToken = decodePlayerIdentityTokenResponse.PlayerIdentityToken;
            if (playerIdentityToken.Provider != "provider") throw new Exception("Provider not recognised.");
            if (playerIdentityToken.ProjectName != ProjectName) throw new Exception("Project not recognised.");
            if (DateTime.Now.CompareTo(playerIdentityToken.ExpiryTime.ToDateTime()) > 0) throw new Exception("PlayerIdentityToken expired.");

            Console.WriteLine("Choosing a deployment");
            var suitableDeployment = _deploymentServiceClient.ListDeployments(new ListDeploymentsRequest
            {
                ProjectName = ProjectName,
                Filters = {
                    new Filter
                    {
                        TagsPropertyFilter = new TagsPropertyFilter
                        {
                            Tag = "player_auth_tag",
                            Operator = TagsPropertyFilter.Types.Operator.Equal,
                        },
                    }
                }
            }).First();

            Console.WriteLine("Creating a LoginToken for the selected deployment");
            var createLoginTokenResponse = _playerAuthServiceClient.CreateLoginToken(
                new CreateLoginTokenRequest
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken,
                    DeploymentId = suitableDeployment.Id.ToString(),
                    LifetimeDuration = Duration.FromTimeSpan(new TimeSpan(0, 0, 30, 0)),
                    WorkerType = ScenarioWorkerType
                }
            );

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
                Network = { ConnectionType = NetworkConnectionType.Tcp, UseExternalIp = true }
            }))
            {
                var connFuture = connectionFuture.Get(Convert.ToUInt32(Defaults.ConnectionTimeoutMillis));
                if (!connFuture.HasValue || !connFuture.Value.IsConnected) throw new Exception("No connection or connection not established");
                Console.WriteLine($"Assigned worker ID: {connFuture.Value.GetWorkerId()}");
            }
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