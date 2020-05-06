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

namespace CNSilo
{
    internal class CNSilo : ScenarioBase
    {
        /// <summary>
        ///     Specifies the CN silo endpoint of SpatialOS, where the domain is *.spatialoschina.com rather then the default *.improbable.io.
        /// </summary>
        private static readonly PlatformApiEndpoint Endpoint =
            new PlatformApiEndpoint("playerauth.api.spatialoschina.com", 443);

        /// <summary>
        ///     Specifies the CN silo authorization endpoint of SpatialOS, where the domain is *.spatialoschina.com rather then the default *.improbable.io.
        /// </summary>
        private const string AuthorizationServerUrl = "https://auth.spatialoschina.com/auth/v1/authcode";

        /// <summary>
        ///     Specifies the CN silo token server endpoint of SpatialOS, where the domain is *.spatialoschina.com rather then the default *.improbable.io.
        /// </summary>
        private const string TokenServerUrl = "https://auth.spatialoschina.com/auth/v1/token";

        private static readonly PlatformRefreshTokenCredential CredentialWithProvidedToken =
            new PlatformRefreshTokenCredential(RefreshToken, AuthorizationServerUrl, TokenServerUrl);

        private readonly PlayerAuthServiceClient _playerAuthServiceClient =
            PlayerAuthServiceClient.Create(credentials: CredentialWithProvidedToken, endpoint: Endpoint);

        /// <summary>
        ///     PLEASE REPLACE.
        ///     Your SpatialOS project name. This project needs to exist in CN silo.
        ///     It should be the same as the name specified in the local project definition file (spatialos.json) used to start the local API service.
        /// </summary>
        private const string ProjectName = "platform_sdk_examples";

        /// <summary>
        ///     PLEASE REPLACE.
        ///     The SpatialOS refresh token of a service account or a user account.
        ///     NOTE: Make sure that your token has been issued for CN silo for this example!
        /// </summary>
        private static string RefreshToken =>
            Environment.GetEnvironmentVariable("IMPROBABLE_REFRESH_TOKEN") ?? "PLEASE_REPLACE_ME";

        protected override void Setup()
        {
        }

        protected override void Run()
        {
            Console.WriteLine("Creating a PlayerIdentityToken with CN Silo");
            var playerIdentityTokenResponse = _playerAuthServiceClient.CreatePlayerIdentityToken(
                new CreatePlayerIdentityTokenRequest
                {
                    Provider = "provider",
                    PlayerIdentifier = "player_identifier",
                    ProjectName = ProjectName
                });

            Console.WriteLine("Verifying PlayerIdentityToken with CN Silo");
            var decodePlayerIdentityTokenResponse = _playerAuthServiceClient.DecodePlayerIdentityToken(
                new DecodePlayerIdentityTokenRequest
                {
                    PlayerIdentityToken = playerIdentityTokenResponse.PlayerIdentityToken
                });
            var playerIdentityToken = decodePlayerIdentityTokenResponse.PlayerIdentityToken;
            if (playerIdentityToken.Provider != "provider") throw new Exception("Provider not recognised.");
            if (playerIdentityToken.ProjectName != ProjectName) throw new Exception("Project not recognised.");
            if (DateTime.Now.CompareTo(playerIdentityToken.ExpiryTime.ToDateTime()) > 0)
                throw new Exception("PlayerIdentityToken expired.");
        }

        protected override void Cleanup()
        {
        }
    }

    internal class Program
    {
        private static readonly ScenarioBase Scenario = new CNSilo();

        private static void Main(string[] args)
        {
            Scenario.Execute();
        }
    }
}