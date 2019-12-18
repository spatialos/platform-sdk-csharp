// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;

namespace Improbable.SpatialOS.Platform
{
    internal static class Helpers
    {
        public static readonly string ManagedWorkerClientIdEnvVar = "IMPROBABLE_CLIENT_ID";
        public static readonly string ManagerWorkerClientSecretEnvVar = "IMPROBABLE_CLIENT_SECRET";

        public static readonly IEnumerable<string> DefaultScopes = new List<string> { "[*]:*" };
        public static readonly ClientSecrets DefaultSecrets = new ClientSecrets
        {
            // This client ID is purposely chosen to be compatible with the default settings of the spatial CLI tool
            // so that the SDK can reuse the refresh token retrieved and stored via spatial CLI.
            ClientId = "improbable_cli_client_go",
            // Despite its name, it carries no significance during the auth flow.
            ClientSecret = "SuperTrouperBeamsAreGonnaBlindMeButIWontFeelBlueLifeIAwaysDoCauseSomewhereInTheCrowdTheresYou",
        };
        public static readonly string DefaultUserId = "dummy_user_id";

        private static Dictionary<Silo, Dictionary<PlatformEnvironment, string>> siloToTokenFileSuffix = new Dictionary<Silo, Dictionary<PlatformEnvironment, string>>
        {
            { Silo.China, new Dictionary<PlatformEnvironment, string> {
                { PlatformEnvironment.Production, "_cn-production" },
                { PlatformEnvironment.Staging, "_cn-staging" },
                { PlatformEnvironment.Testing, "_cn-testing" },
            }},
            { Silo.Global, new Dictionary<PlatformEnvironment, string> {
                { PlatformEnvironment.Production, "" },
                { PlatformEnvironment.Staging, "_staging" },
                { PlatformEnvironment.Testing, "_testing" },
            }},
        };

        public static List<string> TokenFilePaths(Silo silo)
        {
            var tokenFilePaths = new List<string> { };
            switch (silo)
            {
                case Silo.UnknownSilo:
                case Silo.Local:
                    break;
                default:
                    var tokenFile = $"oauth2_refresh_token{siloToTokenFileSuffix[silo][ServiceEndpoint.GetEnvironment()]}";

                    var home = Environment.GetEnvironmentVariable("HOME");
                    if (String.IsNullOrEmpty(home))
                    {
                        home = Environment.GetEnvironmentVariable("LOCALAPPDATA");
                    }
                    if (!String.IsNullOrEmpty(home))
                    {
                        tokenFilePaths.Add(Path.Combine(new string[] { home, ".improbable", "oauth2", tokenFile }));
                    }
                    break;
            }
            return tokenFilePaths;
        }
    }

    internal static class Credentials
    {
        public static Grpc.Core.ChannelCredentials Create(Silo silo, string refreshToken = null)
        {
            string resolvedRefreshToken = null;
            var tokenFilePath = Helpers.TokenFilePaths(silo).FirstOrDefault(File.Exists);
            if (!String.IsNullOrEmpty(refreshToken))
            {
                resolvedRefreshToken = refreshToken;
            }
            else if (!String.IsNullOrEmpty(tokenFilePath))
            {
                try
                {
                    resolvedRefreshToken = File.ReadAllText(tokenFilePath);
                }
                catch (IOException)
                {
                    throw new NoRefreshTokenFoundException($"Failed to read the content of {tokenFilePath}.");
                }
            }

            if (String.IsNullOrEmpty(resolvedRefreshToken))
            {
                throw new NoRefreshTokenFoundException(
                    "No explicit refresh token was specified and none of the default token sources could be resolved. " +
                    "Please check SpatialOS documentation on how to authenticate your Platform SDK clients."
                );
            }

            ClientSecrets resolvedClientSecrets = Helpers.DefaultSecrets;
            var envClientId = Environment.GetEnvironmentVariable(Helpers.ManagedWorkerClientIdEnvVar);
            var envClientSecret = Environment.GetEnvironmentVariable(Helpers.ManagerWorkerClientSecretEnvVar);
            if (!String.IsNullOrEmpty(envClientId) && !String.IsNullOrEmpty(envClientSecret))
            {
                resolvedClientSecrets = new ClientSecrets
                {
                    ClientId = envClientId,
                    ClientSecret = envClientSecret,
                };
            }

            var baseUrl = ServiceEndpoint.GetAuthBaseUrl(silo);
            return Grpc.Auth.GoogleGrpcCredentials.ToChannelCredentials(new UserCredential(
                new AuthorizationCodeFlow(
                    new AuthorizationCodeFlow.Initializer(baseUrl + "/authcode", baseUrl + "/token")
                    {
                        ClientSecrets = resolvedClientSecrets,
                        Scopes = Helpers.DefaultScopes,
                    }
                ),
                Helpers.DefaultUserId,
                new TokenResponse { RefreshToken = resolvedRefreshToken }
            ));
        }
    }
}
