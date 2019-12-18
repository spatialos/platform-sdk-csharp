// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using linq = System.Linq;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Improbable.SpatialOS.ServiceAccount.V1Alpha1
{
    /// <summary>
    /// Settings for a <see cref="ServiceAccountServiceClient"/>.
    /// </summary>
    public sealed partial class ServiceAccountServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ServiceAccountServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ServiceAccountServiceSettings"/>.
        /// </returns>
        public static ServiceAccountServiceSettings GetDefault() => new ServiceAccountServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ServiceAccountServiceSettings"/> object with default settings.
        /// </summary>
        public ServiceAccountServiceSettings() { }

        private ServiceAccountServiceSettings(ServiceAccountServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateServiceAccountSettings = existing.CreateServiceAccountSettings;
            ListServiceAccountsSettings = existing.ListServiceAccountsSettings;
            UpdateServiceAccountSettings = existing.UpdateServiceAccountSettings;
            DeleteServiceAccountSettings = existing.DeleteServiceAccountSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ServiceAccountServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ServiceAccountServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ServiceAccountServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ServiceAccountServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ServiceAccountServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ServiceAccountServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ServiceAccountServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ServiceAccountServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ServiceAccountServiceClient"/> RPC methods is defined as:
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
        /// <c>ServiceAccountServiceClient.CreateServiceAccount</c> and <c>ServiceAccountServiceClient.CreateServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceAccountServiceClient.CreateServiceAccount</c> and
        /// <c>ServiceAccountServiceClient.CreateServiceAccountAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateServiceAccountSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceAccountServiceClient.ListServiceAccounts</c> and <c>ServiceAccountServiceClient.ListServiceAccountsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceAccountServiceClient.ListServiceAccounts</c> and
        /// <c>ServiceAccountServiceClient.ListServiceAccountsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListServiceAccountsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceAccountServiceClient.UpdateServiceAccount</c> and <c>ServiceAccountServiceClient.UpdateServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceAccountServiceClient.UpdateServiceAccount</c> and
        /// <c>ServiceAccountServiceClient.UpdateServiceAccountAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateServiceAccountSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceAccountServiceClient.DeleteServiceAccount</c> and <c>ServiceAccountServiceClient.DeleteServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceAccountServiceClient.DeleteServiceAccount</c> and
        /// <c>ServiceAccountServiceClient.DeleteServiceAccountAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteServiceAccountSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ServiceAccountServiceSettings"/> object.</returns>
        public ServiceAccountServiceSettings Clone() => new ServiceAccountServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ServiceAccountServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ServiceAccountServiceClientBuilder : gaxgrpc::ClientBuilderBase<ServiceAccountServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public ServiceAccountServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override ServiceAccountServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ServiceAccountServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<ServiceAccountServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ServiceAccountServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ServiceAccountServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ServiceAccountServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => ServiceAccountServiceClient.ChannelPool;
    }

    /// <summary>
    /// ServiceAccountService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ServiceAccountServiceClient
    {
        /// <summary>
        /// The default endpoint for the ServiceAccountService service, which is a host of "platform.api.improbable.io" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("platform.api.improbable.io", 443);

        /// <summary>
        /// The default ServiceAccountService scopes.
        /// </summary>
        /// <remarks>
        /// The default ServiceAccountService scopes are:
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
        /// Asynchronously creates a <see cref="ServiceAccountServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Improbable.SpatialOS.ServiceAccount.V1Alpha1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ServiceAccountServiceClient client = await ServiceAccountServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Improbable.SpatialOS.ServiceAccount.V1Alpha1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ServiceAccountServiceClient.DefaultEndpoint.Host, ServiceAccountServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ServiceAccountServiceClient client = ServiceAccountServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ServiceAccountServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ServiceAccountServiceClient"/>.</returns>
        public static async stt::Task<ServiceAccountServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ServiceAccountServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ServiceAccountServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Improbable.SpatialOS.ServiceAccount.V1Alpha1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ServiceAccountServiceClient client = ServiceAccountServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Improbable.SpatialOS.ServiceAccount.V1Alpha1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ServiceAccountServiceClient.DefaultEndpoint.Host, ServiceAccountServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ServiceAccountServiceClient client = ServiceAccountServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ServiceAccountServiceSettings"/>.</param>
        /// <returns>The created <see cref="ServiceAccountServiceClient"/>.</returns>
        public static ServiceAccountServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ServiceAccountServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ServiceAccountServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ServiceAccountServiceSettings"/>.</param>
        /// <returns>The created <see cref="ServiceAccountServiceClient"/>.</returns>
        public static ServiceAccountServiceClient Create(grpccore::Channel channel, ServiceAccountServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ServiceAccountServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ServiceAccountServiceSettings"/>.</param>
        /// <returns>The created <see cref="ServiceAccountServiceClient"/>.</returns>
        public static ServiceAccountServiceClient Create(grpccore::CallInvoker callInvoker, ServiceAccountServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ServiceAccountService.ServiceAccountServiceClient grpcClient = new ServiceAccountService.ServiceAccountServiceClient(callInvoker);
            return new ServiceAccountServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ServiceAccountServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ServiceAccountServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ServiceAccountServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ServiceAccountServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ServiceAccountService client.
        /// </summary>
        public virtual ServiceAccountService.ServiceAccountServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectName">
        /// The name of the project associated with the service account.
        /// </param>
        /// <param name="name">
        /// The name of the service account.
        /// </param>
        /// <param name="permissions">
        /// The service account's scope.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceAccount> CreateServiceAccountAsync(
            string projectName,
            string name,
            scg::IEnumerable<Permission> permissions,
            gaxgrpc::CallSettings callSettings = null) => CreateServiceAccountAsync(
                new CreateServiceAccountRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectName">
        /// The name of the project associated with the service account.
        /// </param>
        /// <param name="name">
        /// The name of the service account.
        /// </param>
        /// <param name="permissions">
        /// The service account's scope.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceAccount> CreateServiceAccountAsync(
            string projectName,
            string name,
            scg::IEnumerable<Permission> permissions,
            st::CancellationToken cancellationToken) => CreateServiceAccountAsync(
                projectName,
                name,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectName">
        /// The name of the project associated with the service account.
        /// </param>
        /// <param name="name">
        /// The name of the service account.
        /// </param>
        /// <param name="permissions">
        /// The service account's scope.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceAccount CreateServiceAccount(
            string projectName,
            string name,
            scg::IEnumerable<Permission> permissions,
            gaxgrpc::CallSettings callSettings = null) => CreateServiceAccount(
                new CreateServiceAccountRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        ///
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
        public virtual stt::Task<ServiceAccount> CreateServiceAccountAsync(
            CreateServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        ///
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
        public virtual stt::Task<ServiceAccount> CreateServiceAccountAsync(
            CreateServiceAccountRequest request,
            st::CancellationToken cancellationToken) => CreateServiceAccountAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
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
        public virtual ServiceAccount CreateServiceAccount(
            CreateServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectName">
        /// The name of the project whose service accounts should be listed. You must have access to this
        /// project.
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
        /// A pageable asynchronous sequence of <see cref="ServiceAccount"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccountsAsync(
            string projectName,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListServiceAccountsAsync(
                new ListServiceAccountsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectName">
        /// The name of the project whose service accounts should be listed. You must have access to this
        /// project.
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
        /// A pageable sequence of <see cref="ServiceAccount"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccounts(
            string projectName,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListServiceAccounts(
                new ListServiceAccountsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ServiceAccount"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccountsAsync(
            ListServiceAccountsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ServiceAccount"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccounts(
            ListServiceAccountsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="id">
        /// The ID of the service account which is to be updated.
        /// </param>
        /// <param name="expirationTime">
        /// An updated expiration time for the account. This cannot be more than 90 days in the future.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceAccount> UpdateServiceAccountAsync(
            long id,
            pbwkt::Timestamp expirationTime,
            gaxgrpc::CallSettings callSettings = null) => UpdateServiceAccountAsync(
                new UpdateServiceAccountRequest
                {
                    Id = id,
                    ExpirationTime = expirationTime, // Optional
                },
                callSettings);

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="id">
        /// The ID of the service account which is to be updated.
        /// </param>
        /// <param name="expirationTime">
        /// An updated expiration time for the account. This cannot be more than 90 days in the future.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceAccount> UpdateServiceAccountAsync(
            long id,
            pbwkt::Timestamp expirationTime,
            st::CancellationToken cancellationToken) => UpdateServiceAccountAsync(
                id,
                expirationTime,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="id">
        /// The ID of the service account which is to be updated.
        /// </param>
        /// <param name="expirationTime">
        /// An updated expiration time for the account. This cannot be more than 90 days in the future.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceAccount UpdateServiceAccount(
            long id,
            pbwkt::Timestamp expirationTime,
            gaxgrpc::CallSettings callSettings = null) => UpdateServiceAccount(
                new UpdateServiceAccountRequest
                {
                    Id = id,
                    ExpirationTime = expirationTime, // Optional
                },
                callSettings);

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="id">
        /// The ID of the service account which is to be updated.
        /// </param>
        /// <param name="permissions">
        /// An updated set of grants for the service account.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceAccount> UpdateServiceAccountAsync(
            long id,
            scg::IEnumerable<Permission> permissions,
            gaxgrpc::CallSettings callSettings = null) => UpdateServiceAccountAsync(
                new UpdateServiceAccountRequest
                {
                    Id = id,
                    Permissions = { permissions ?? linq::Enumerable.Empty<Permission>() }, // Optional
                },
                callSettings);

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="id">
        /// The ID of the service account which is to be updated.
        /// </param>
        /// <param name="permissions">
        /// An updated set of grants for the service account.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceAccount> UpdateServiceAccountAsync(
            long id,
            scg::IEnumerable<Permission> permissions,
            st::CancellationToken cancellationToken) => UpdateServiceAccountAsync(
                id,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="id">
        /// The ID of the service account which is to be updated.
        /// </param>
        /// <param name="permissions">
        /// An updated set of grants for the service account.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceAccount UpdateServiceAccount(
            long id,
            scg::IEnumerable<Permission> permissions,
            gaxgrpc::CallSettings callSettings = null) => UpdateServiceAccount(
                new UpdateServiceAccountRequest
                {
                    Id = id,
                    Permissions = { permissions ?? linq::Enumerable.Empty<Permission>() }, // Optional
                },
                callSettings);

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
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
        public virtual stt::Task<ServiceAccount> UpdateServiceAccountAsync(
            UpdateServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
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
        public virtual stt::Task<ServiceAccount> UpdateServiceAccountAsync(
            UpdateServiceAccountRequest request,
            st::CancellationToken cancellationToken) => UpdateServiceAccountAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
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
        public virtual ServiceAccount UpdateServiceAccount(
            UpdateServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please add a
        /// (potentially empty) standard DeleteServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="id">
        /// ID of the service account to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceAccountAsync(
            long id,
            gaxgrpc::CallSettings callSettings = null) => DeleteServiceAccountAsync(
                new DeleteServiceAccountRequest
                {
                    Id = id,
                },
                callSettings);

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please add a
        /// (potentially empty) standard DeleteServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="id">
        /// ID of the service account to delete.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceAccountAsync(
            long id,
            st::CancellationToken cancellationToken) => DeleteServiceAccountAsync(
                id,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please add a
        /// (potentially empty) standard DeleteServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="id">
        /// ID of the service account to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteServiceAccount(
            long id,
            gaxgrpc::CallSettings callSettings = null) => DeleteServiceAccount(
                new DeleteServiceAccountRequest
                {
                    Id = id,
                },
                callSettings);

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please add a
        /// (potentially empty) standard DeleteServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceAccountAsync(
            DeleteServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please add a
        /// (potentially empty) standard DeleteServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceAccountAsync(
            DeleteServiceAccountRequest request,
            st::CancellationToken cancellationToken) => DeleteServiceAccountAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please add a
        /// (potentially empty) standard DeleteServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteServiceAccount(
            DeleteServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ServiceAccountService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ServiceAccountServiceClientImpl : ServiceAccountServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateServiceAccountRequest, ServiceAccount> _callCreateServiceAccount;
        private readonly gaxgrpc::ApiCall<ListServiceAccountsRequest, ListServiceAccountsResponse> _callListServiceAccounts;
        private readonly gaxgrpc::ApiCall<UpdateServiceAccountRequest, ServiceAccount> _callUpdateServiceAccount;
        private readonly gaxgrpc::ApiCall<DeleteServiceAccountRequest, pbwkt::Empty> _callDeleteServiceAccount;

        /// <summary>
        /// Constructs a client wrapper for the ServiceAccountService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ServiceAccountServiceSettings"/> used within this client </param>
        public ServiceAccountServiceClientImpl(ServiceAccountService.ServiceAccountServiceClient grpcClient, ServiceAccountServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ServiceAccountServiceSettings effectiveSettings = settings ?? ServiceAccountServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateServiceAccount = clientHelper.BuildApiCall<CreateServiceAccountRequest, ServiceAccount>(
                GrpcClient.CreateServiceAccountAsync, GrpcClient.CreateServiceAccount, effectiveSettings.CreateServiceAccountSettings);
            _callListServiceAccounts = clientHelper.BuildApiCall<ListServiceAccountsRequest, ListServiceAccountsResponse>(
                GrpcClient.ListServiceAccountsAsync, GrpcClient.ListServiceAccounts, effectiveSettings.ListServiceAccountsSettings);
            _callUpdateServiceAccount = clientHelper.BuildApiCall<UpdateServiceAccountRequest, ServiceAccount>(
                GrpcClient.UpdateServiceAccountAsync, GrpcClient.UpdateServiceAccount, effectiveSettings.UpdateServiceAccountSettings);
            _callDeleteServiceAccount = clientHelper.BuildApiCall<DeleteServiceAccountRequest, pbwkt::Empty>(
                GrpcClient.DeleteServiceAccountAsync, GrpcClient.DeleteServiceAccount, effectiveSettings.DeleteServiceAccountSettings);
            Modify_ApiCall(ref _callCreateServiceAccount);
            Modify_CreateServiceAccountApiCall(ref _callCreateServiceAccount);
            Modify_ApiCall(ref _callListServiceAccounts);
            Modify_ListServiceAccountsApiCall(ref _callListServiceAccounts);
            Modify_ApiCall(ref _callUpdateServiceAccount);
            Modify_UpdateServiceAccountApiCall(ref _callUpdateServiceAccount);
            Modify_ApiCall(ref _callDeleteServiceAccount);
            Modify_DeleteServiceAccountApiCall(ref _callDeleteServiceAccount);
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
        partial void Modify_CreateServiceAccountApiCall(ref gaxgrpc::ApiCall<CreateServiceAccountRequest, ServiceAccount> call);
        partial void Modify_ListServiceAccountsApiCall(ref gaxgrpc::ApiCall<ListServiceAccountsRequest, ListServiceAccountsResponse> call);
        partial void Modify_UpdateServiceAccountApiCall(ref gaxgrpc::ApiCall<UpdateServiceAccountRequest, ServiceAccount> call);
        partial void Modify_DeleteServiceAccountApiCall(ref gaxgrpc::ApiCall<DeleteServiceAccountRequest, pbwkt::Empty> call);
        partial void OnConstruction(ServiceAccountService.ServiceAccountServiceClient grpcClient, ServiceAccountServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ServiceAccountService client.
        /// </summary>
        public override ServiceAccountService.ServiceAccountServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateServiceAccountRequest(ref CreateServiceAccountRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListServiceAccountsRequest(ref ListServiceAccountsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateServiceAccountRequest(ref UpdateServiceAccountRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteServiceAccountRequest(ref DeleteServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        ///
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
        public override stt::Task<ServiceAccount> CreateServiceAccountAsync(
            CreateServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceAccountRequest(ref request, ref callSettings);
            return _callCreateServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        ///
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
        public override ServiceAccount CreateServiceAccount(
            CreateServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceAccountRequest(ref request, ref callSettings);
            return _callCreateServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ServiceAccount"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccountsAsync(
            ListServiceAccountsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceAccountsRequest, ListServiceAccountsResponse, ServiceAccount>(_callListServiceAccounts, request, callSettings);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ServiceAccount"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListServiceAccountsResponse, ServiceAccount> ListServiceAccounts(
            ListServiceAccountsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceAccountsRequest, ListServiceAccountsResponse, ServiceAccount>(_callListServiceAccounts, request, callSettings);
        }

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
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
        public override stt::Task<ServiceAccount> UpdateServiceAccountAsync(
            UpdateServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceAccountRequest(ref request, ref callSettings);
            return _callUpdateServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please use a
        /// standard UpdateServiceAccountResponse struct.
        /// !!! WARNING !!!
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
        public override ServiceAccount UpdateServiceAccount(
            UpdateServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceAccountRequest(ref request, ref callSettings);
            return _callUpdateServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please add a
        /// (potentially empty) standard DeleteServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteServiceAccountAsync(
            DeleteServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceAccountRequest(ref request, ref callSettings);
            return _callDeleteServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// !!! WARNING !!!
        /// When this API is moved to beta/stable please add a
        /// (potentially empty) standard DeleteServiceAccountResponse struct.
        /// !!! WARNING !!!
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteServiceAccount(
            DeleteServiceAccountRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceAccountRequest(ref request, ref callSettings);
            _callDeleteServiceAccount.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListServiceAccountsRequest : gaxgrpc::IPageRequest { }
    public partial class ListServiceAccountsResponse : gaxgrpc::IPageResponse<ServiceAccount>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ServiceAccount> GetEnumerator() => ServiceAccounts.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
