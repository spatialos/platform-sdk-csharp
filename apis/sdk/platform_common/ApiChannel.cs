// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using System.Collections.Generic;
using System.Reflection;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;

namespace Improbable.SpatialOS.Platform.Common {
    /// <inheritdoc />
    /// <summary>
    ///     The channel wrapping the endpoint of a SpatialOS Platform API and a SpatialOS credential.
    /// </summary>
    public class PlatformApiChannel : Channel {
        private static readonly string AgentInfo = "platform-sdk-csharp/" + typeof(PlatformApiChannel).GetTypeInfo().Assembly.GetName().Version;

        /// <inheritdoc />
        /// <summary>
        ///     Initializes a new instance of the <see cref="PlatformApiChannel" /> class with a given SpatialOS Platform API
        ///     endpoint and credential.
        /// </summary>
        /// <exception cref="NoCredentialInSecureConnectionException">
        ///     Thrown when no credential is provided for a secure connection.
        /// </exception>
        /// <param name="apiEndpoint">The endpoint of the SpatialOS Platform API.</param>
        /// <param name="credential">The credential to authenticate with the API server.</param>
        public PlatformApiChannel(ITokenAccess credential, PlatformApiEndpoint apiEndpoint) :
            base(
                apiEndpoint.Host,
                apiEndpoint.Port,
                ConstructChannelCredentials(credential, apiEndpoint.Insecure),
                new List<ChannelOption>
                {
                    new ChannelOption(ChannelOptions.PrimaryUserAgentString, AgentInfo)
                }) { }


        private static ChannelCredentials ConstructChannelCredentials(ITokenAccess credential, bool insecure) {
            if (insecure) return ChannelCredentials.Insecure;

            if (credential == null) throw new NoCredentialInSecureConnectionException();

            return ChannelCredentials.Create(new SslCredentials(),
                CallCredentials.FromInterceptor(GoogleAuthInterceptors.FromCredential(credential)));
        }
    }
}