// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Improbable.SpatialOS.Snapshot.V1Alpha1
{
    /// <summary>
    /// Settings for a <see cref="SnapshotServiceClient"/>.
    /// </summary>
    public sealed partial class SnapshotServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SnapshotServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SnapshotServiceSettings"/>.
        /// </returns>
        public static SnapshotServiceSettings GetDefault() => new SnapshotServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SnapshotServiceSettings"/> object with default settings.
        /// </summary>
        public SnapshotServiceSettings() { }

        private SnapshotServiceSettings(SnapshotServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSnapshotsSettings = existing.ListSnapshotsSettings;
            GetSnapshotSettings = existing.GetSnapshotSettings;
            TakeSnapshotSettings = existing.TakeSnapshotSettings;
            TakeSnapshotOperationsSettings = existing.TakeSnapshotOperationsSettings?.Clone();
            UploadSnapshotSettings = existing.UploadSnapshotSettings;
            ConfirmUploadSettings = existing.ConfirmUploadSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SnapshotServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SnapshotServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="SnapshotServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="SnapshotServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="SnapshotServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SnapshotServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 50 milliseconds</description></item>
        /// <item><description>Maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(50),
            maxDelay: sys::TimeSpan.FromMilliseconds(10000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="SnapshotServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SnapshotServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SnapshotServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(60000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnapshotServiceClient.ListSnapshots</c> and <c>SnapshotServiceClient.ListSnapshotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SnapshotServiceClient.ListSnapshots</c> and
        /// <c>SnapshotServiceClient.ListSnapshotsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 50 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListSnapshotsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnapshotServiceClient.GetSnapshot</c> and <c>SnapshotServiceClient.GetSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SnapshotServiceClient.GetSnapshot</c> and
        /// <c>SnapshotServiceClient.GetSnapshotAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 50 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnapshotServiceClient.TakeSnapshot</c> and <c>SnapshotServiceClient.TakeSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SnapshotServiceClient.TakeSnapshot</c> and
        /// <c>SnapshotServiceClient.TakeSnapshotAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 50 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings TakeSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SnapshotServiceClient.TakeSnapshot</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 2000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.1</description></item>
        /// <item><description>Maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings TakeSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000L)),
                sys::TimeSpan.FromMilliseconds(2000L),
                1.1,
                sys::TimeSpan.FromMilliseconds(10000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnapshotServiceClient.UploadSnapshot</c> and <c>SnapshotServiceClient.UploadSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SnapshotServiceClient.UploadSnapshot</c> and
        /// <c>SnapshotServiceClient.UploadSnapshotAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 50 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UploadSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnapshotServiceClient.ConfirmUpload</c> and <c>SnapshotServiceClient.ConfirmUploadAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SnapshotServiceClient.ConfirmUpload</c> and
        /// <c>SnapshotServiceClient.ConfirmUploadAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 50 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ConfirmUploadSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SnapshotServiceSettings"/> object.</returns>
        public SnapshotServiceSettings Clone() => new SnapshotServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SnapshotServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SnapshotServiceClientBuilder : gaxgrpc::ClientBuilderBase<SnapshotServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public SnapshotServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override SnapshotServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SnapshotServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<SnapshotServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SnapshotServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => SnapshotServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SnapshotServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => SnapshotServiceClient.ChannelPool;
    }

    /// <summary>
    /// SnapshotService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SnapshotServiceClient
    {
        /// <summary>
        /// The default endpoint for the SnapshotService service, which is a host of "platform.api.improbable.io" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("platform.api.improbable.io", 443);

        /// <summary>
        /// The default SnapshotService scopes.
        /// </summary>
        /// <remarks>
        /// The default SnapshotService scopes are:
        /// <list type="bullet">
        /// <item><description>"Unused because of our custom authentication setup."</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "Unused because of our custom authentication setup.",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="SnapshotServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Improbable.SpatialOS.Snapshot.V1Alpha1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SnapshotServiceClient client = await SnapshotServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Improbable.SpatialOS.Snapshot.V1Alpha1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SnapshotServiceClient.DefaultEndpoint.Host, SnapshotServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SnapshotServiceClient client = SnapshotServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SnapshotServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SnapshotServiceClient"/>.</returns>
        public static async stt::Task<SnapshotServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, SnapshotServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SnapshotServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Improbable.SpatialOS.Snapshot.V1Alpha1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SnapshotServiceClient client = SnapshotServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Improbable.SpatialOS.Snapshot.V1Alpha1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SnapshotServiceClient.DefaultEndpoint.Host, SnapshotServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SnapshotServiceClient client = SnapshotServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SnapshotServiceSettings"/>.</param>
        /// <returns>The created <see cref="SnapshotServiceClient"/>.</returns>
        public static SnapshotServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, SnapshotServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SnapshotServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SnapshotServiceSettings"/>.</param>
        /// <returns>The created <see cref="SnapshotServiceClient"/>.</returns>
        public static SnapshotServiceClient Create(grpccore::Channel channel, SnapshotServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="SnapshotServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SnapshotServiceSettings"/>.</param>
        /// <returns>The created <see cref="SnapshotServiceClient"/>.</returns>
        public static SnapshotServiceClient Create(grpccore::CallInvoker callInvoker, SnapshotServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SnapshotService.SnapshotServiceClient grpcClient = new SnapshotService.SnapshotServiceClient(callInvoker);
            return new SnapshotServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, SnapshotServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SnapshotServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, SnapshotServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SnapshotServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC SnapshotService client.
        /// </summary>
        public virtual SnapshotService.SnapshotServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists snapshots under a deployment. By default, snapshots are sorted by creation time
        /// (descending).
        /// </summary>
        /// <param name="projectName">
        /// The name of the project to list snapshots for.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="deploymentName">
        /// The deployment to list snapshots for.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            string projectName,
            string deploymentName,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSnapshotsAsync(
                new ListSnapshotsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    DeploymentName = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentName, nameof(deploymentName)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists snapshots under a deployment. By default, snapshots are sorted by creation time
        /// (descending).
        /// </summary>
        /// <param name="projectName">
        /// The name of the project to list snapshots for.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="deploymentName">
        /// The deployment to list snapshots for.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            string projectName,
            string deploymentName,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSnapshots(
                new ListSnapshotsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    DeploymentName = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentName, nameof(deploymentName)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists snapshots under a deployment. By default, snapshots are sorted by creation time
        /// (descending).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists snapshots under a deployment. By default, snapshots are sorted by creation time
        /// (descending).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a snapshot.
        /// </summary>
        /// <param name="projectName">
        /// The project the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="deploymentName">
        /// The deployment the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="id">
        /// The identifier for the snapshot.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetSnapshotResponse> GetSnapshotAsync(
            string projectName,
            string deploymentName,
            string id,
            gaxgrpc::CallSettings callSettings = null) => GetSnapshotAsync(
                new GetSnapshotRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    DeploymentName = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentName, nameof(deploymentName)),
                    Id = gax::GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id)),
                },
                callSettings);

        /// <summary>
        /// Gets a snapshot.
        /// </summary>
        /// <param name="projectName">
        /// The project the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="deploymentName">
        /// The deployment the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="id">
        /// The identifier for the snapshot.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetSnapshotResponse> GetSnapshotAsync(
            string projectName,
            string deploymentName,
            string id,
            st::CancellationToken cancellationToken) => GetSnapshotAsync(
                projectName,
                deploymentName,
                id,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a snapshot.
        /// </summary>
        /// <param name="projectName">
        /// The project the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="deploymentName">
        /// The deployment the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="id">
        /// The identifier for the snapshot.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual GetSnapshotResponse GetSnapshot(
            string projectName,
            string deploymentName,
            string id,
            gaxgrpc::CallSettings callSettings = null) => GetSnapshot(
                new GetSnapshotRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    DeploymentName = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentName, nameof(deploymentName)),
                    Id = gax::GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id)),
                },
                callSettings);

        /// <summary>
        /// Gets a snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetSnapshotResponse> GetSnapshotAsync(
            GetSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetSnapshotResponse> GetSnapshotAsync(
            GetSnapshotRequest request,
            st::CancellationToken cancellationToken) => GetSnapshotAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual GetSnapshotResponse GetSnapshot(
            GetSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Takes a snapshot. You can only take snapshots of running deployments.
        ///
        /// The returned operation result is of type `snapshot` upon successfully taking a snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// These fields are mandatory:
        /// - `project_name`
        /// - `deployment_name`
        ///
        /// These fields are optional:
        /// - `tags`
        ///
        /// Other set values will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Snapshot, TakeSnapshotMetadata>> TakeSnapshotAsync(
            Snapshot snapshot,
            gaxgrpc::CallSettings callSettings = null) => TakeSnapshotAsync(
                new TakeSnapshotRequest
                {
                    Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                },
                callSettings);

        /// <summary>
        /// Takes a snapshot. You can only take snapshots of running deployments.
        ///
        /// The returned operation result is of type `snapshot` upon successfully taking a snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// These fields are mandatory:
        /// - `project_name`
        /// - `deployment_name`
        ///
        /// These fields are optional:
        /// - `tags`
        ///
        /// Other set values will be ignored.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Snapshot, TakeSnapshotMetadata>> TakeSnapshotAsync(
            Snapshot snapshot,
            st::CancellationToken cancellationToken) => TakeSnapshotAsync(
                snapshot,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Takes a snapshot. You can only take snapshots of running deployments.
        ///
        /// The returned operation result is of type `snapshot` upon successfully taking a snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// These fields are mandatory:
        /// - `project_name`
        /// - `deployment_name`
        ///
        /// These fields are optional:
        /// - `tags`
        ///
        /// Other set values will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Snapshot, TakeSnapshotMetadata> TakeSnapshot(
            Snapshot snapshot,
            gaxgrpc::CallSettings callSettings = null) => TakeSnapshot(
                new TakeSnapshotRequest
                {
                    Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                },
                callSettings);

        /// <summary>
        /// Takes a snapshot. You can only take snapshots of running deployments.
        ///
        /// The returned operation result is of type `snapshot` upon successfully taking a snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Snapshot, TakeSnapshotMetadata>> TakeSnapshotAsync(
            TakeSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TakeSnapshotAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, TakeSnapshotMetadata>> PollOnceTakeSnapshotAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Snapshot, TakeSnapshotMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                TakeSnapshotOperationsClient,
                callSettings);

        /// <summary>
        /// Takes a snapshot. You can only take snapshots of running deployments.
        ///
        /// The returned operation result is of type `snapshot` upon successfully taking a snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Snapshot, TakeSnapshotMetadata> TakeSnapshot(
            TakeSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>TakeSnapshot</c>.
        /// </summary>
        public virtual lro::OperationsClient TakeSnapshotOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TakeSnapshot</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Snapshot, TakeSnapshotMetadata> PollOnceTakeSnapshot(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Snapshot, TakeSnapshotMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                TakeSnapshotOperationsClient,
                callSettings);

        /// <summary>
        /// Allocates space and returns a URL to upload a snapshot to.
        /// </summary>
        /// <param name="snapshot">
        /// These fields are mandatory:
        /// - `project_name`
        /// - `deployment_name`
        /// - `checksum`
        ///
        /// These fields are optional:
        /// - `tags`
        ///
        /// Other set values will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UploadSnapshotResponse> UploadSnapshotAsync(
            Snapshot snapshot,
            gaxgrpc::CallSettings callSettings = null) => UploadSnapshotAsync(
                new UploadSnapshotRequest
                {
                    Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                },
                callSettings);

        /// <summary>
        /// Allocates space and returns a URL to upload a snapshot to.
        /// </summary>
        /// <param name="snapshot">
        /// These fields are mandatory:
        /// - `project_name`
        /// - `deployment_name`
        /// - `checksum`
        ///
        /// These fields are optional:
        /// - `tags`
        ///
        /// Other set values will be ignored.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UploadSnapshotResponse> UploadSnapshotAsync(
            Snapshot snapshot,
            st::CancellationToken cancellationToken) => UploadSnapshotAsync(
                snapshot,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allocates space and returns a URL to upload a snapshot to.
        /// </summary>
        /// <param name="snapshot">
        /// These fields are mandatory:
        /// - `project_name`
        /// - `deployment_name`
        /// - `checksum`
        ///
        /// These fields are optional:
        /// - `tags`
        ///
        /// Other set values will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UploadSnapshotResponse UploadSnapshot(
            Snapshot snapshot,
            gaxgrpc::CallSettings callSettings = null) => UploadSnapshot(
                new UploadSnapshotRequest
                {
                    Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                },
                callSettings);

        /// <summary>
        /// Allocates space and returns a URL to upload a snapshot to.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UploadSnapshotResponse> UploadSnapshotAsync(
            UploadSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Allocates space and returns a URL to upload a snapshot to.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UploadSnapshotResponse> UploadSnapshotAsync(
            UploadSnapshotRequest request,
            st::CancellationToken cancellationToken) => UploadSnapshotAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allocates space and returns a URL to upload a snapshot to.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UploadSnapshotResponse UploadSnapshot(
            UploadSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Confirms that a snapshot is uploaded to the URL allocated by the `UploadSnapshot` RPC and makes
        /// it available for use in a deployment.
        /// </summary>
        /// <param name="projectName">
        /// The project the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="deploymentName">
        /// The deployment the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="id">
        /// The identifier for the uploaded snapshot.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ConfirmUploadResponse> ConfirmUploadAsync(
            string projectName,
            string deploymentName,
            string id,
            gaxgrpc::CallSettings callSettings = null) => ConfirmUploadAsync(
                new ConfirmUploadRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    DeploymentName = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentName, nameof(deploymentName)),
                    Id = gax::GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id)),
                },
                callSettings);

        /// <summary>
        /// Confirms that a snapshot is uploaded to the URL allocated by the `UploadSnapshot` RPC and makes
        /// it available for use in a deployment.
        /// </summary>
        /// <param name="projectName">
        /// The project the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="deploymentName">
        /// The deployment the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="id">
        /// The identifier for the uploaded snapshot.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ConfirmUploadResponse> ConfirmUploadAsync(
            string projectName,
            string deploymentName,
            string id,
            st::CancellationToken cancellationToken) => ConfirmUploadAsync(
                projectName,
                deploymentName,
                id,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Confirms that a snapshot is uploaded to the URL allocated by the `UploadSnapshot` RPC and makes
        /// it available for use in a deployment.
        /// </summary>
        /// <param name="projectName">
        /// The project the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="deploymentName">
        /// The deployment the snapshot belongs to.
        ///
        /// It must conform to the regex: ^[a-z0-9_]{3,32}$
        /// </param>
        /// <param name="id">
        /// The identifier for the uploaded snapshot.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ConfirmUploadResponse ConfirmUpload(
            string projectName,
            string deploymentName,
            string id,
            gaxgrpc::CallSettings callSettings = null) => ConfirmUpload(
                new ConfirmUploadRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    DeploymentName = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentName, nameof(deploymentName)),
                    Id = gax::GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id)),
                },
                callSettings);

        /// <summary>
        /// Confirms that a snapshot is uploaded to the URL allocated by the `UploadSnapshot` RPC and makes
        /// it available for use in a deployment.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ConfirmUploadResponse> ConfirmUploadAsync(
            ConfirmUploadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Confirms that a snapshot is uploaded to the URL allocated by the `UploadSnapshot` RPC and makes
        /// it available for use in a deployment.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ConfirmUploadResponse> ConfirmUploadAsync(
            ConfirmUploadRequest request,
            st::CancellationToken cancellationToken) => ConfirmUploadAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Confirms that a snapshot is uploaded to the URL allocated by the `UploadSnapshot` RPC and makes
        /// it available for use in a deployment.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ConfirmUploadResponse ConfirmUpload(
            ConfirmUploadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// SnapshotService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SnapshotServiceClientImpl : SnapshotServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> _callListSnapshots;
        private readonly gaxgrpc::ApiCall<GetSnapshotRequest, GetSnapshotResponse> _callGetSnapshot;
        private readonly gaxgrpc::ApiCall<TakeSnapshotRequest, lro::Operation> _callTakeSnapshot;
        private readonly gaxgrpc::ApiCall<UploadSnapshotRequest, UploadSnapshotResponse> _callUploadSnapshot;
        private readonly gaxgrpc::ApiCall<ConfirmUploadRequest, ConfirmUploadResponse> _callConfirmUpload;

        /// <summary>
        /// Constructs a client wrapper for the SnapshotService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SnapshotServiceSettings"/> used within this client </param>
        public SnapshotServiceClientImpl(SnapshotService.SnapshotServiceClient grpcClient, SnapshotServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SnapshotServiceSettings effectiveSettings = settings ?? SnapshotServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            TakeSnapshotOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.TakeSnapshotOperationsSettings);
            _callListSnapshots = clientHelper.BuildApiCall<ListSnapshotsRequest, ListSnapshotsResponse>(
                GrpcClient.ListSnapshotsAsync, GrpcClient.ListSnapshots, effectiveSettings.ListSnapshotsSettings);
            _callGetSnapshot = clientHelper.BuildApiCall<GetSnapshotRequest, GetSnapshotResponse>(
                GrpcClient.GetSnapshotAsync, GrpcClient.GetSnapshot, effectiveSettings.GetSnapshotSettings);
            _callTakeSnapshot = clientHelper.BuildApiCall<TakeSnapshotRequest, lro::Operation>(
                GrpcClient.TakeSnapshotAsync, GrpcClient.TakeSnapshot, effectiveSettings.TakeSnapshotSettings);
            _callUploadSnapshot = clientHelper.BuildApiCall<UploadSnapshotRequest, UploadSnapshotResponse>(
                GrpcClient.UploadSnapshotAsync, GrpcClient.UploadSnapshot, effectiveSettings.UploadSnapshotSettings);
            _callConfirmUpload = clientHelper.BuildApiCall<ConfirmUploadRequest, ConfirmUploadResponse>(
                GrpcClient.ConfirmUploadAsync, GrpcClient.ConfirmUpload, effectiveSettings.ConfirmUploadSettings);
            Modify_ApiCall(ref _callListSnapshots);
            Modify_ListSnapshotsApiCall(ref _callListSnapshots);
            Modify_ApiCall(ref _callGetSnapshot);
            Modify_GetSnapshotApiCall(ref _callGetSnapshot);
            Modify_ApiCall(ref _callTakeSnapshot);
            Modify_TakeSnapshotApiCall(ref _callTakeSnapshot);
            Modify_ApiCall(ref _callUploadSnapshot);
            Modify_UploadSnapshotApiCall(ref _callUploadSnapshot);
            Modify_ApiCall(ref _callConfirmUpload);
            Modify_ConfirmUploadApiCall(ref _callConfirmUpload);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_ListSnapshotsApiCall(ref gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> call);
        partial void Modify_GetSnapshotApiCall(ref gaxgrpc::ApiCall<GetSnapshotRequest, GetSnapshotResponse> call);
        partial void Modify_TakeSnapshotApiCall(ref gaxgrpc::ApiCall<TakeSnapshotRequest, lro::Operation> call);
        partial void Modify_UploadSnapshotApiCall(ref gaxgrpc::ApiCall<UploadSnapshotRequest, UploadSnapshotResponse> call);
        partial void Modify_ConfirmUploadApiCall(ref gaxgrpc::ApiCall<ConfirmUploadRequest, ConfirmUploadResponse> call);
        partial void OnConstruction(SnapshotService.SnapshotServiceClient grpcClient, SnapshotServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC SnapshotService client.
        /// </summary>
        public override SnapshotService.SnapshotServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListSnapshotsRequest(ref ListSnapshotsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetSnapshotRequest(ref GetSnapshotRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TakeSnapshotRequest(ref TakeSnapshotRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UploadSnapshotRequest(ref UploadSnapshotRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ConfirmUploadRequest(ref ConfirmUploadRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists snapshots under a deployment. By default, snapshots are sorted by creation time
        /// (descending).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// Lists snapshots under a deployment. By default, snapshots are sorted by creation time
        /// (descending).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// Gets a snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<GetSnapshotResponse> GetSnapshotAsync(
            GetSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override GetSnapshotResponse GetSnapshot(
            GetSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Takes a snapshot. You can only take snapshots of running deployments.
        ///
        /// The returned operation result is of type `snapshot` upon successfully taking a snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async stt::Task<lro::Operation<Snapshot, TakeSnapshotMetadata>> TakeSnapshotAsync(
            TakeSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TakeSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, TakeSnapshotMetadata>(
                await _callTakeSnapshot.Async(request, callSettings).ConfigureAwait(false), TakeSnapshotOperationsClient);
        }

        /// <summary>
        /// Takes a snapshot. You can only take snapshots of running deployments.
        ///
        /// The returned operation result is of type `snapshot` upon successfully taking a snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override lro::Operation<Snapshot, TakeSnapshotMetadata> TakeSnapshot(
            TakeSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TakeSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, TakeSnapshotMetadata>(
                _callTakeSnapshot.Sync(request, callSettings), TakeSnapshotOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>TakeSnapshot</c>.
        /// </summary>
        public override lro::OperationsClient TakeSnapshotOperationsClient { get; }

        /// <summary>
        /// Allocates space and returns a URL to upload a snapshot to.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<UploadSnapshotResponse> UploadSnapshotAsync(
            UploadSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadSnapshotRequest(ref request, ref callSettings);
            return _callUploadSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Allocates space and returns a URL to upload a snapshot to.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override UploadSnapshotResponse UploadSnapshot(
            UploadSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadSnapshotRequest(ref request, ref callSettings);
            return _callUploadSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Confirms that a snapshot is uploaded to the URL allocated by the `UploadSnapshot` RPC and makes
        /// it available for use in a deployment.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ConfirmUploadResponse> ConfirmUploadAsync(
            ConfirmUploadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfirmUploadRequest(ref request, ref callSettings);
            return _callConfirmUpload.Async(request, callSettings);
        }

        /// <summary>
        /// Confirms that a snapshot is uploaded to the URL allocated by the `UploadSnapshot` RPC and makes
        /// it available for use in a deployment.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ConfirmUploadResponse ConfirmUpload(
            ConfirmUploadRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfirmUploadRequest(ref request, ref callSettings);
            return _callConfirmUpload.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListSnapshotsRequest : gaxgrpc::IPageRequest { }
    public partial class ListSnapshotsResponse : gaxgrpc::IPageResponse<Snapshot>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Snapshot> GetEnumerator() => Snapshot.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class SnapshotService
    {
        public partial class SnapshotServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
