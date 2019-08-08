// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;

namespace Improbable.SpatialOS.Platform.Common
{
    /// <inheritdoc />
    /// <summary>
    ///     This is the abstract base class for SpatialOS platform credentials. Clients should use a concrete credential provider
    ///     such as <see cref="PlatformRefreshTokenCredential" /> instead of trying to instantiate this class directly.
    /// </summary>
    public abstract class PlatformCredential : UserCredential
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="flow">The OAuth authorization flow.</param>
        /// <param name="userId">The user ID string.</param>
        /// <param name="token">The OAuth token.</param>
        protected PlatformCredential(IAuthorizationCodeFlow flow, string userId, TokenResponse token)
            : base(flow, userId, token) { }
    }

    /// <inheritdoc />
    /// <summary>
    ///     This provides support to automatically acquire access tokens from SpatialOS refresh tokens.
    /// </summary>
    public class PlatformRefreshTokenCredential : PlatformCredential
    {
        private const string DefaultTokenFileEnvVar = "SPATIALOS_REFRESH_TOKEN_FILE";
        private const string DummyUserId = "dummy_user_id";
        private const string AuthorizationServerUrl = "https://auth.improbable.io/auth/v1/authcode";
        private const string TokenServerUrl = "https://auth.improbable.io/auth/v1/token";
        private const string RefreshTokenNotFoundMessage = "Please check if environment variable " + DefaultTokenFileEnvVar + " is set to the correct path or try running `spatial init` to fetch and store a new refresh token locally.";

        private static readonly Lazy<PlatformRefreshTokenCredential> AutoDetectedLazy =
            new Lazy<PlatformRefreshTokenCredential>(GetTokenCredentialAutomatically);

        private static readonly ClientSecrets DefaultSecrets = new ClientSecrets
        {
            // This client ID is purposely chosen to be compatible with the default settings of the spatial CLI tool
            // so that the SDK can reuse the refresh token retrieved and stored via spatial CLI.
            ClientId = "improbable_cli_client_go",
            // Despite its name, it carries no significance during the auth flow.
            ClientSecret =
                "SuperTrouperBeamsAreGonnaBlindMeButIWontFeelBlueLifeIAwaysDoCauseSomewhereInTheCrowdTheresYou"
        };

        private static readonly IEnumerable<string> DefaultScopes = new List<string> { "[*]:*" };

        /// <summary>
        ///     Initializes a new instance of the <see cref="PlatformRefreshTokenCredential" /> class that uses the supplied
        ///     refresh token to authenticate with Improbable's OAuth servers.
        /// </summary>
        /// <param name="refreshToken">The SpatialOS refresh token.</param>
        /// <param name="tokenServerUrl">The URL of the OAuth token server. Defaults to Improbable's production OAuth token server.</param>
        /// <param name="scopes">The scope to request for the OAuth server. Defaults to "[*]:*".</param>
        /// <param name="authServerUrl">The URL of the OAuth auth server. Defaults to Improbable's production OAuth auth server.</param>
        /// <param name="clientSecrets">The client secrets for the SpatialOS refresh token.</param>
        public PlatformRefreshTokenCredential(string refreshToken, string authServerUrl = null,
            string tokenServerUrl = null, IEnumerable<string> scopes = null, ClientSecrets clientSecrets = null)
            : base(
                new AuthorizationCodeFlow(
                    new AuthorizationCodeFlow.Initializer(
                        authServerUrl ?? AuthorizationServerUrl,
                        tokenServerUrl ?? TokenServerUrl
                    )
                    {
                        Scopes = scopes ?? DefaultScopes,
                        ClientSecrets = clientSecrets ?? DefaultSecrets
                    }),
                DummyUserId,
                new TokenResponse { RefreshToken = refreshToken }
            )
        { }

        /// <inheritdoc />
        /// <summary>
        ///     This constructor provides a way to allow more control over the OAuth 2.0 authentication flow.
        /// </summary>
        /// <param name="flow">The OAuth authorization flow.</param>
        /// <param name="userId">The user ID string.</param>
        /// <param name="token">The OAuth token.</param>
        public PlatformRefreshTokenCredential(IAuthorizationCodeFlow flow, string userId, TokenResponse token)
            : base(flow, userId, token) { }

        /// <summary>
        ///     Gets an instance of the <see cref="PlatformRefreshTokenCredential" /> class by retrieving the locally stored
        ///     refresh token from a file.
        ///     It tries to determine the path to the refresh token in the following order:
        ///     1. use the environment variable `SPATIALOS_REFRESH_TOKEN_FILE`
        ///     2. use the same well-known location `spatial` CLI tool uses, e.g. `$HOME/.improbable/oauth2/oauth2_refresh_token` on a Mac;
        ///     Note: invoking `spatial init` creates the refresh token file in the well-known location.
        /// </summary>
        /// <exception cref="NoRefreshTokenFoundException">
        ///     Thrown when no refresh token is found in the specified location or the
        ///     well-known location.
        /// </exception>
        public static PlatformRefreshTokenCredential AutoDetected => AutoDetectedLazy.Value;

        private static PlatformRefreshTokenCredential GetTokenCredentialAutomatically()
        {
            var serverRefreshToken = Environment.GetEnvironmentVariable("IMPROBABLE_PLATFORM_REFRESH_TOKEN");
            if (!string.IsNullOrEmpty(serverRefreshToken))
            {
                var clientSecrets = new ClientSecrets
                {
                    ClientId = Environment.GetEnvironmentVariable("IMPROBABLE_CLIENT_ID"),
                    ClientSecret = Environment.GetEnvironmentVariable("IMPROBABLE_CLIENT_SECRET")
                };
                if (clientSecrets.ClientId != "" && clientSecrets.ClientSecret != "")
                {
                    return new PlatformRefreshTokenCredential(serverRefreshToken, null, null, null, clientSecrets);
                }
            }

            var possibleTokenFiles = new[]
            {
                Path.Combine(Environment.GetEnvironmentVariable("HOME") ?? "", ".improbable/oauth2/oauth2_refresh_token"),
                Path.Combine(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%"), ".improbable/oauth2/oauth2_refresh_token")
            };

            var tokenFile = possibleTokenFiles.FirstOrDefault(File.Exists);
            if (!string.IsNullOrEmpty(tokenFile))
            {
                try
                {
                    var refreshToken = File.ReadAllText(tokenFile);
                    return new PlatformRefreshTokenCredential(refreshToken);
                }
                catch (IOException)
                {
                    throw new NoRefreshTokenFoundException(RefreshTokenNotFoundMessage);
                }
            }

            // Fail if no form of credentials could be found.
            throw new NoRefreshTokenFoundException(RefreshTokenNotFoundMessage);
        }
    }
}
