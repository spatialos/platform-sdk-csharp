// Copyright 2018, Improbable Worlds Ltd rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using ispc = Improbable.SpatialOS.Platform.Common;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Improbable.SpatialOS.RemoteInteraction.V1Alpha1
{
    /// <summary>
    /// Settings for a <see cref="RemoteInteractionServiceClient"/>.
    /// </summary>
    public sealed partial class RemoteInteractionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="RemoteInteractionServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="RemoteInteractionServiceSettings"/>.
        /// </returns>
        public static RemoteInteractionServiceSettings GetDefault() => new RemoteInteractionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RemoteInteractionServiceSettings"/> object with default settings.
        /// </summary>
        public RemoteInteractionServiceSettings() { }

        private RemoteInteractionServiceSettings(RemoteInteractionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            EntityCommandSettings = existing.EntityCommandSettings;
            ReserveEntityIdSettings = existing.ReserveEntityIdSettings;
            CreateEntitySettings = existing.CreateEntitySettings;
            DeleteEntitySettings = existing.DeleteEntitySettings;
            EntityQuerySettings = existing.EntityQuerySettings;
            OnCopy(existing);
        }

        partial void OnCopy(RemoteInteractionServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="RemoteInteractionServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable);

        /// <summary>
        /// "Default" retry backoff for <see cref="RemoteInteractionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="RemoteInteractionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="RemoteInteractionServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(10000),
            delayMultiplier: 1.2
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="RemoteInteractionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="RemoteInteractionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="RemoteInteractionServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.2</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(10000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.2
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RemoteInteractionServiceClient.EntityCommand</c> and <c>RemoteInteractionServiceClient.EntityCommandAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>RemoteInteractionServiceClient.EntityCommand</c> and
        /// <c>RemoteInteractionServiceClient.EntityCommandAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.2</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 60000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings EntityCommandSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RemoteInteractionServiceClient.ReserveEntityId</c> and <c>RemoteInteractionServiceClient.ReserveEntityIdAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>RemoteInteractionServiceClient.ReserveEntityId</c> and
        /// <c>RemoteInteractionServiceClient.ReserveEntityIdAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.2</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 60000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ReserveEntityIdSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RemoteInteractionServiceClient.CreateEntity</c> and <c>RemoteInteractionServiceClient.CreateEntityAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>RemoteInteractionServiceClient.CreateEntity</c> and
        /// <c>RemoteInteractionServiceClient.CreateEntityAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.2</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 60000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntitySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RemoteInteractionServiceClient.DeleteEntity</c> and <c>RemoteInteractionServiceClient.DeleteEntityAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>RemoteInteractionServiceClient.DeleteEntity</c> and
        /// <c>RemoteInteractionServiceClient.DeleteEntityAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.2</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 60000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntitySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RemoteInteractionServiceClient.EntityQuery</c> and <c>RemoteInteractionServiceClient.EntityQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>RemoteInteractionServiceClient.EntityQuery</c> and
        /// <c>RemoteInteractionServiceClient.EntityQueryAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Initial timeout: 10000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.2</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 60000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings EntityQuerySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="RemoteInteractionServiceSettings"/> object.</returns>
        public RemoteInteractionServiceSettings Clone() => new RemoteInteractionServiceSettings(this);
    }

    /// <summary>
    /// RemoteInteractionService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class RemoteInteractionServiceClient
    {
        /// <summary>
        /// The default endpoint for the RemoteInteractionService service, which is a host of "platform.api.improbable.io" and a port of 443.
        /// </summary>
        public static ispc::PlatformApiEndpoint DefaultEndpoint { get; } = new ispc::PlatformApiEndpoint("platform.api.improbable.io", 443);

        /// <summary>
        /// Synchronously creates a <see cref="RemoteInteractionServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application auto-detected credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ispc::PlatformApiEndpoint"/>.</param>
        /// <param name="credentials">Optional, most likely a <see cref="ispc::PlatformRefreshTokenCredential"/>.</param>
        /// <param name="settings">Optional <see cref="RemoteInteractionServiceSettings"/>.</param>
        /// <returns>The created <see cref="RemoteInteractionServiceClient"/>.</returns>
        public static RemoteInteractionServiceClient Create(ispc::PlatformApiEndpoint endpoint = null, ispc::PlatformCredential credentials = null, RemoteInteractionServiceSettings settings = null)
        {
            var platformEndpoint = endpoint ?? DefaultEndpoint;
            var platformCredentials = platformEndpoint.Insecure ? null : credentials ?? ispc::PlatformRefreshTokenCredential.AutoDetected;
            grpccore::Channel channel = new ispc::PlatformApiChannel(platformCredentials, platformEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="RemoteInteractionServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="RemoteInteractionServiceSettings"/>.</param>
        /// <returns>The created <see cref="RemoteInteractionServiceClient"/>.</returns>
        public static RemoteInteractionServiceClient Create(grpccore::Channel channel, RemoteInteractionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            RemoteInteractionService.RemoteInteractionServiceClient grpcClient = new RemoteInteractionService.RemoteInteractionServiceClient(channel);
            return new RemoteInteractionServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// The underlying gRPC RemoteInteractionService client.
        /// </summary>
        public virtual RemoteInteractionService.RemoteInteractionServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="workerType">
        ///
        /// </param>
        /// <param name="workerId">
        ///
        /// </param>
        /// <param name="componentTarget">
        ///
        /// </param>
        /// <param name="binary">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityCommandResponse> EntityCommandAsync(
            Deployment target,
            string workerType,
            string workerId,
            EntityCommandRequest.Types.EntityCommandTarget componentTarget,
            pb::ByteString binary,
            gaxgrpc::CallSettings callSettings = null) => EntityCommandAsync(
                new EntityCommandRequest
                {
                    Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
                    WorkerType = gax::GaxPreconditions.CheckNotNullOrEmpty(workerType, nameof(workerType)),
                    WorkerId = gax::GaxPreconditions.CheckNotNullOrEmpty(workerId, nameof(workerId)),
                    ComponentTarget = gax::GaxPreconditions.CheckNotNull(componentTarget, nameof(componentTarget)),
                    Binary = binary ?? pb::ByteString.Empty, // Optional
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="workerType">
        ///
        /// </param>
        /// <param name="workerId">
        ///
        /// </param>
        /// <param name="componentTarget">
        ///
        /// </param>
        /// <param name="binary">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityCommandResponse> EntityCommandAsync(
            Deployment target,
            string workerType,
            string workerId,
            EntityCommandRequest.Types.EntityCommandTarget componentTarget,
            pb::ByteString binary,
            st::CancellationToken cancellationToken) => EntityCommandAsync(
                target,
                workerType,
                workerId,
                componentTarget,
                binary,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="workerType">
        ///
        /// </param>
        /// <param name="workerId">
        ///
        /// </param>
        /// <param name="componentTarget">
        ///
        /// </param>
        /// <param name="binary">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityCommandResponse EntityCommand(
            Deployment target,
            string workerType,
            string workerId,
            EntityCommandRequest.Types.EntityCommandTarget componentTarget,
            pb::ByteString binary,
            gaxgrpc::CallSettings callSettings = null) => EntityCommand(
                new EntityCommandRequest
                {
                    Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
                    WorkerType = gax::GaxPreconditions.CheckNotNullOrEmpty(workerType, nameof(workerType)),
                    WorkerId = gax::GaxPreconditions.CheckNotNullOrEmpty(workerId, nameof(workerId)),
                    ComponentTarget = gax::GaxPreconditions.CheckNotNull(componentTarget, nameof(componentTarget)),
                    Binary = binary ?? pb::ByteString.Empty, // Optional
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
        public virtual stt::Task<EntityCommandResponse> EntityCommandAsync(
            EntityCommandRequest request,
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
        public virtual stt::Task<EntityCommandResponse> EntityCommandAsync(
            EntityCommandRequest request,
            st::CancellationToken cancellationToken) => EntityCommandAsync(
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
        public virtual EntityCommandResponse EntityCommand(
            EntityCommandRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="numberOfIds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReserveEntityIdResponse> ReserveEntityIdAsync(
            Deployment target,
            uint? numberOfIds,
            gaxgrpc::CallSettings callSettings = null) => ReserveEntityIdAsync(
                new ReserveEntityIdRequest
                {
                    Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
                    NumberOfIds = numberOfIds ?? 0, // Optional
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="numberOfIds">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReserveEntityIdResponse> ReserveEntityIdAsync(
            Deployment target,
            uint? numberOfIds,
            st::CancellationToken cancellationToken) => ReserveEntityIdAsync(
                target,
                numberOfIds,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="numberOfIds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReserveEntityIdResponse ReserveEntityId(
            Deployment target,
            uint? numberOfIds,
            gaxgrpc::CallSettings callSettings = null) => ReserveEntityId(
                new ReserveEntityIdRequest
                {
                    Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
                    NumberOfIds = numberOfIds ?? 0, // Optional
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
        public virtual stt::Task<ReserveEntityIdResponse> ReserveEntityIdAsync(
            ReserveEntityIdRequest request,
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
        public virtual stt::Task<ReserveEntityIdResponse> ReserveEntityIdAsync(
            ReserveEntityIdRequest request,
            st::CancellationToken cancellationToken) => ReserveEntityIdAsync(
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
        public virtual ReserveEntityIdResponse ReserveEntityId(
            ReserveEntityIdRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="entityId">
        ///
        /// </param>
        /// <param name="binary">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateEntityResponse> CreateEntityAsync(
            Deployment target,
            long entityId,
            pb::ByteString binary,
            gaxgrpc::CallSettings callSettings = null) => CreateEntityAsync(
                new CreateEntityRequest
                {
                    Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
                    EntityId = entityId,
                    Binary = binary ?? pb::ByteString.Empty, // Optional
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="entityId">
        ///
        /// </param>
        /// <param name="binary">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateEntityResponse> CreateEntityAsync(
            Deployment target,
            long entityId,
            pb::ByteString binary,
            st::CancellationToken cancellationToken) => CreateEntityAsync(
                target,
                entityId,
                binary,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="entityId">
        ///
        /// </param>
        /// <param name="binary">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CreateEntityResponse CreateEntity(
            Deployment target,
            long entityId,
            pb::ByteString binary,
            gaxgrpc::CallSettings callSettings = null) => CreateEntity(
                new CreateEntityRequest
                {
                    Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
                    EntityId = entityId,
                    Binary = binary ?? pb::ByteString.Empty, // Optional
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
        public virtual stt::Task<CreateEntityResponse> CreateEntityAsync(
            CreateEntityRequest request,
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
        public virtual stt::Task<CreateEntityResponse> CreateEntityAsync(
            CreateEntityRequest request,
            st::CancellationToken cancellationToken) => CreateEntityAsync(
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
        public virtual CreateEntityResponse CreateEntity(
            CreateEntityRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="entityId">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DeleteEntityResponse> DeleteEntityAsync(
            Deployment target,
            long entityId,
            gaxgrpc::CallSettings callSettings = null) => DeleteEntityAsync(
                new DeleteEntityRequest
                {
                    Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
                    EntityId = entityId,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="entityId">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DeleteEntityResponse> DeleteEntityAsync(
            Deployment target,
            long entityId,
            st::CancellationToken cancellationToken) => DeleteEntityAsync(
                target,
                entityId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="entityId">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DeleteEntityResponse DeleteEntity(
            Deployment target,
            long entityId,
            gaxgrpc::CallSettings callSettings = null) => DeleteEntity(
                new DeleteEntityRequest
                {
                    Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
                    EntityId = entityId,
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
        public virtual stt::Task<DeleteEntityResponse> DeleteEntityAsync(
            DeleteEntityRequest request,
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
        public virtual stt::Task<DeleteEntityResponse> DeleteEntityAsync(
            DeleteEntityRequest request,
            st::CancellationToken cancellationToken) => DeleteEntityAsync(
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
        public virtual DeleteEntityResponse DeleteEntity(
            DeleteEntityRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="binary">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityQueryResponse> EntityQueryAsync(
            Deployment target,
            pb::ByteString binary,
            gaxgrpc::CallSettings callSettings = null) => EntityQueryAsync(
                new EntityQueryRequest
                {
                    Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
                    Binary = binary ?? pb::ByteString.Empty, // Optional
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="binary">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityQueryResponse> EntityQueryAsync(
            Deployment target,
            pb::ByteString binary,
            st::CancellationToken cancellationToken) => EntityQueryAsync(
                target,
                binary,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="target">
        ///
        /// </param>
        /// <param name="binary">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityQueryResponse EntityQuery(
            Deployment target,
            pb::ByteString binary,
            gaxgrpc::CallSettings callSettings = null) => EntityQuery(
                new EntityQueryRequest
                {
                    Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
                    Binary = binary ?? pb::ByteString.Empty, // Optional
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
        public virtual stt::Task<EntityQueryResponse> EntityQueryAsync(
            EntityQueryRequest request,
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
        public virtual stt::Task<EntityQueryResponse> EntityQueryAsync(
            EntityQueryRequest request,
            st::CancellationToken cancellationToken) => EntityQueryAsync(
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
        public virtual EntityQueryResponse EntityQuery(
            EntityQueryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// RemoteInteractionService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class RemoteInteractionServiceClientImpl : RemoteInteractionServiceClient
    {
        private readonly gaxgrpc::ApiCall<EntityCommandRequest, EntityCommandResponse> _callEntityCommand;
        private readonly gaxgrpc::ApiCall<ReserveEntityIdRequest, ReserveEntityIdResponse> _callReserveEntityId;
        private readonly gaxgrpc::ApiCall<CreateEntityRequest, CreateEntityResponse> _callCreateEntity;
        private readonly gaxgrpc::ApiCall<DeleteEntityRequest, DeleteEntityResponse> _callDeleteEntity;
        private readonly gaxgrpc::ApiCall<EntityQueryRequest, EntityQueryResponse> _callEntityQuery;

        /// <summary>
        /// Constructs a client wrapper for the RemoteInteractionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RemoteInteractionServiceSettings"/> used within this client </param>
        public RemoteInteractionServiceClientImpl(RemoteInteractionService.RemoteInteractionServiceClient grpcClient, RemoteInteractionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            RemoteInteractionServiceSettings effectiveSettings = settings ?? RemoteInteractionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callEntityCommand = clientHelper.BuildApiCall<EntityCommandRequest, EntityCommandResponse>(
                GrpcClient.EntityCommandAsync, GrpcClient.EntityCommand, effectiveSettings.EntityCommandSettings);
            _callReserveEntityId = clientHelper.BuildApiCall<ReserveEntityIdRequest, ReserveEntityIdResponse>(
                GrpcClient.ReserveEntityIdAsync, GrpcClient.ReserveEntityId, effectiveSettings.ReserveEntityIdSettings);
            _callCreateEntity = clientHelper.BuildApiCall<CreateEntityRequest, CreateEntityResponse>(
                GrpcClient.CreateEntityAsync, GrpcClient.CreateEntity, effectiveSettings.CreateEntitySettings);
            _callDeleteEntity = clientHelper.BuildApiCall<DeleteEntityRequest, DeleteEntityResponse>(
                GrpcClient.DeleteEntityAsync, GrpcClient.DeleteEntity, effectiveSettings.DeleteEntitySettings);
            _callEntityQuery = clientHelper.BuildApiCall<EntityQueryRequest, EntityQueryResponse>(
                GrpcClient.EntityQueryAsync, GrpcClient.EntityQuery, effectiveSettings.EntityQuerySettings);
            Modify_ApiCall(ref _callEntityCommand);
            Modify_EntityCommandApiCall(ref _callEntityCommand);
            Modify_ApiCall(ref _callReserveEntityId);
            Modify_ReserveEntityIdApiCall(ref _callReserveEntityId);
            Modify_ApiCall(ref _callCreateEntity);
            Modify_CreateEntityApiCall(ref _callCreateEntity);
            Modify_ApiCall(ref _callDeleteEntity);
            Modify_DeleteEntityApiCall(ref _callDeleteEntity);
            Modify_ApiCall(ref _callEntityQuery);
            Modify_EntityQueryApiCall(ref _callEntityQuery);
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
        partial void Modify_EntityCommandApiCall(ref gaxgrpc::ApiCall<EntityCommandRequest, EntityCommandResponse> call);
        partial void Modify_ReserveEntityIdApiCall(ref gaxgrpc::ApiCall<ReserveEntityIdRequest, ReserveEntityIdResponse> call);
        partial void Modify_CreateEntityApiCall(ref gaxgrpc::ApiCall<CreateEntityRequest, CreateEntityResponse> call);
        partial void Modify_DeleteEntityApiCall(ref gaxgrpc::ApiCall<DeleteEntityRequest, DeleteEntityResponse> call);
        partial void Modify_EntityQueryApiCall(ref gaxgrpc::ApiCall<EntityQueryRequest, EntityQueryResponse> call);
        partial void OnConstruction(RemoteInteractionService.RemoteInteractionServiceClient grpcClient, RemoteInteractionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC RemoteInteractionService client.
        /// </summary>
        public override RemoteInteractionService.RemoteInteractionServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_EntityCommandRequest(ref EntityCommandRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ReserveEntityIdRequest(ref ReserveEntityIdRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateEntityRequest(ref CreateEntityRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteEntityRequest(ref DeleteEntityRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_EntityQueryRequest(ref EntityQueryRequest request, ref gaxgrpc::CallSettings settings);

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
        public override stt::Task<EntityCommandResponse> EntityCommandAsync(
            EntityCommandRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EntityCommandRequest(ref request, ref callSettings);
            return _callEntityCommand.Async(request, callSettings);
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
        public override EntityCommandResponse EntityCommand(
            EntityCommandRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EntityCommandRequest(ref request, ref callSettings);
            return _callEntityCommand.Sync(request, callSettings);
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
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ReserveEntityIdResponse> ReserveEntityIdAsync(
            ReserveEntityIdRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReserveEntityIdRequest(ref request, ref callSettings);
            return _callReserveEntityId.Async(request, callSettings);
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
        public override ReserveEntityIdResponse ReserveEntityId(
            ReserveEntityIdRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReserveEntityIdRequest(ref request, ref callSettings);
            return _callReserveEntityId.Sync(request, callSettings);
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
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CreateEntityResponse> CreateEntityAsync(
            CreateEntityRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityRequest(ref request, ref callSettings);
            return _callCreateEntity.Async(request, callSettings);
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
        public override CreateEntityResponse CreateEntity(
            CreateEntityRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityRequest(ref request, ref callSettings);
            return _callCreateEntity.Sync(request, callSettings);
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
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<DeleteEntityResponse> DeleteEntityAsync(
            DeleteEntityRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityRequest(ref request, ref callSettings);
            return _callDeleteEntity.Async(request, callSettings);
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
        public override DeleteEntityResponse DeleteEntity(
            DeleteEntityRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityRequest(ref request, ref callSettings);
            return _callDeleteEntity.Sync(request, callSettings);
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
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<EntityQueryResponse> EntityQueryAsync(
            EntityQueryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EntityQueryRequest(ref request, ref callSettings);
            return _callEntityQuery.Async(request, callSettings);
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
        public override EntityQueryResponse EntityQuery(
            EntityQueryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EntityQueryRequest(ref request, ref callSettings);
            return _callEntityQuery.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
