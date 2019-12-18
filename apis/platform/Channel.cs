// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using System.Reflection;

namespace Improbable.SpatialOS.Platform
{
    /// <summary>
    /// Communication channel used to set up a connection to the API endpoints of the SpatialOS platform.
    /// </summary>
    public static class Channel
    {
        private static readonly string AgentInfo = "platform-sdk-csharp/" + Assembly.GetEntryAssembly().GetName().Version;

        /// <summary>
        /// Create a new <see cref="Channel"/> instance that can connect to the specified <see cref="Service"/> in the targeted <see cref="Silo"/>.
        /// </summary>
        public static Grpc.Core.Channel Create(Service service, Silo silo, string refreshToken = null)
        {
            return new Grpc.Core.Channel(
                ServiceEndpoint.Get(service, silo).ToString(),
                silo == Silo.Local ? Grpc.Core.ChannelCredentials.Insecure : Credentials.Create(silo, refreshToken),
                new[]
                {
                    new Grpc.Core.ChannelOption(Grpc.Core.ChannelOptions.PrimaryUserAgentString, AgentInfo),
                }
            );
        }
    }
}