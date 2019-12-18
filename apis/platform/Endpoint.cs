// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using System;
using System.Collections.Generic;

namespace Improbable.SpatialOS.Platform
{
    /// <summary>
    /// The various services supported by the Platform SDK.
    /// </summary>
    public enum Service
    {
        /// <summary>
        /// Default-value enumerator that will result in an exception when used to construct a PlatformApiEndpoint.
        /// </summary>
        UnknownService = 0,
        /// <summary>
        /// The Deployment service.
        /// </summary>
        DeploymentService = 1,
        /// <summary>
        /// The Long-Running Operations service.
        /// </summary>
        OperationsService = 2,
        /// <summary>
        /// The Player Authentication service.
        /// </summary>
        PlayerAuthService = 3,
        /// <summary>
        /// The Remote Interaction service.
        /// </summary>
        RemoteInteractionService = 4,
        /// <summary>
        /// The Service Account service.
        /// </summary>
        ServiceAccountService = 5,
        /// <summary>
        /// The Snapshot service.
        /// </summary>
        SnapshotService = 6,
    }

    /// <summary>
    /// The various platforms to connect to with the Platform SDK.
    /// </summary>
    public enum Silo
    {
        /// <summary>
        /// Default-value enumerator that will result in an exception when used to construct a PlatformApiEndpoint.
        /// </summary>
        UnknownSilo = 0,
        /// <summary>
        /// Silo to use when contacting the Platform API endpoint for local deployments.
        /// </summary>
        Local = 1,
        /// <summary>
        /// Silo to use when contacting the Platform API endpoint for Improbable's global platform.
        /// </summary>
        Global = 2,
        /// <summary>
        /// Silo to use when contacting the Platform API endpoint for Improbable's platform in China.
        /// </summary>
        China = 3,
    }

    internal enum PlatformEnvironment
    {
        UnknownEnvironment = 0,
        Production = 1,
        Staging = 2,
        Testing = 3,
    }

    internal static class ServiceEndpoint
    {
        private static readonly string TargetEnvironmentEnvVar = "TARGET_ENVIRONMENT";

        private static Dictionary<string, PlatformEnvironment> stringToEnvironment = new Dictionary<string, PlatformEnvironment> {
            { "", PlatformEnvironment.Production },
            { "production", PlatformEnvironment.Production },
            { "staging", PlatformEnvironment.Staging },
            { "testing", PlatformEnvironment.Testing},
        };

        private static Dictionary<Service, string> serviceToEndpoint = new Dictionary<Service, string> {
            { Service.UnknownService, "unknown-service" },
            { Service.DeploymentService, "platform" },
            { Service.OperationsService, "Platform" },
            { Service.PlayerAuthService, "playerauth" },
            { Service.RemoteInteractionService, "platform" },
            { Service.ServiceAccountService, "platform" },
            { Service.SnapshotService, "platform" },
        };

        private static Dictionary<Silo, string> siloToDomain = new Dictionary<Silo, string> {
            { Silo.UnknownSilo, "unknown-domain" },
            { Silo.Local, "127.0.0.1" },
            { Silo.Global, "improbable.io"},
            { Silo.China, "spatialoschina.com" },
        };

        private static Dictionary<Silo, Dictionary<PlatformEnvironment, string>> environmentToSuffix = new Dictionary<Silo, Dictionary<PlatformEnvironment, string>>
        {
            { Silo.China, new Dictionary<PlatformEnvironment, string> {
                { PlatformEnvironment.Production, "" },
                { PlatformEnvironment.Staging, "-cn-staging" },
                { PlatformEnvironment.Testing, "-cn-testing" },
            }},
            { Silo.Global, new Dictionary<PlatformEnvironment, string> {
                { PlatformEnvironment.Production, "" },
                { PlatformEnvironment.Staging, "-staging" },
                { PlatformEnvironment.Testing, "-testing" },
            }},
        };

        public static PlatformEnvironment GetEnvironment()
        {
            var env = PlatformEnvironment.UnknownEnvironment;
            stringToEnvironment.TryGetValue(Environment.GetEnvironmentVariable(TargetEnvironmentEnvVar) ?? "production", out env);
            return env;
        }

        public static Google.Api.Gax.Grpc.ServiceEndpoint Get(Service service, Silo silo)
        {
            var env = GetEnvironment();
            if (service == Service.UnknownService || silo == Silo.UnknownSilo || env == PlatformEnvironment.UnknownEnvironment)
            {
                throw new ArgumentException("The 'service' cannot be set to UnknownService and 'silo' cannot be set to 'UnknownSilo'.");
            }
            if (silo == Silo.Local)
            {
                return new Google.Api.Gax.Grpc.ServiceEndpoint($"{siloToDomain[silo]}", 9876);
            }
            return new Google.Api.Gax.Grpc.ServiceEndpoint($"{serviceToEndpoint[service]}{environmentToSuffix[silo][env]}.api.{siloToDomain[silo]}", 443);
        }

        public static string GetAuthBaseUrl(Silo silo)
        {
            var env = GetEnvironment();
            switch (silo)
            {
                case Silo.UnknownSilo:
                    throw new ArgumentException("The 'silo' cannot be set to 'UnknownSilo'.");
                case Silo.Local:
                    throw new ArgumentException("The 'silo' cannot be set to 'UnknownSilo'.");
                default:
                    return $"https://auth{environmentToSuffix[silo][env]}.{siloToDomain[silo]}/auth/v1";
            }
        }
    }
}