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
using lro = Google.LongRunning;
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

namespace Improbable.SpatialOS.Deployment.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="DeploymentServiceClient"/>.
    /// </summary>
    public sealed partial class DeploymentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DeploymentServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="DeploymentServiceSettings"/>.
        /// </returns>
        public static DeploymentServiceSettings GetDefault() => new DeploymentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DeploymentServiceSettings"/> object with default settings.
        /// </summary>
        public DeploymentServiceSettings() { }

        private DeploymentServiceSettings(DeploymentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDeploymentsSettings = existing.ListDeploymentsSettings;
            GetDeploymentSettings = existing.GetDeploymentSettings;
            GetRunningDeploymentByNameSettings = existing.GetRunningDeploymentByNameSettings;
            CreateDeploymentSettings = existing.CreateDeploymentSettings;
            CreateDeploymentOperationsSettings = existing.CreateDeploymentOperationsSettings?.Clone();
            DeleteDeploymentSettings = existing.DeleteDeploymentSettings;
            DeleteDeploymentOperationsSettings = existing.DeleteDeploymentOperationsSettings?.Clone();
            SetDeploymentWorkerFlagsSettings = existing.SetDeploymentWorkerFlagsSettings;
            SetDeploymentTagsSettings = existing.SetDeploymentTagsSettings;
            SetDeploymentWorkerCapacitiesSettings = existing.SetDeploymentWorkerCapacitiesSettings;
            SetDeploymentWorkerRateLimitsSettings = existing.SetDeploymentWorkerRateLimitsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeploymentServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="DeploymentServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="DeploymentServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="DeploymentServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="DeploymentServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="DeploymentServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="DeploymentServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="DeploymentServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="DeploymentServiceClient"/> RPC methods is defined as:
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
        /// <c>DeploymentServiceClient.ListDeployments</c> and <c>DeploymentServiceClient.ListDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DeploymentServiceClient.ListDeployments</c> and
        /// <c>DeploymentServiceClient.ListDeploymentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListDeploymentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentServiceClient.GetDeployment</c> and <c>DeploymentServiceClient.GetDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DeploymentServiceClient.GetDeployment</c> and
        /// <c>DeploymentServiceClient.GetDeploymentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentServiceClient.GetRunningDeploymentByName</c> and <c>DeploymentServiceClient.GetRunningDeploymentByNameAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DeploymentServiceClient.GetRunningDeploymentByName</c> and
        /// <c>DeploymentServiceClient.GetRunningDeploymentByNameAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetRunningDeploymentByNameSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentServiceClient.CreateDeployment</c> and <c>DeploymentServiceClient.CreateDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DeploymentServiceClient.CreateDeployment</c> and
        /// <c>DeploymentServiceClient.CreateDeploymentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DeploymentServiceClient.CreateDeployment</c>.
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
        public lro::OperationsSettings CreateDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000L)),
                sys::TimeSpan.FromMilliseconds(2000L),
                1.1,
                sys::TimeSpan.FromMilliseconds(10000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentServiceClient.DeleteDeployment</c> and <c>DeploymentServiceClient.DeleteDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DeploymentServiceClient.DeleteDeployment</c> and
        /// <c>DeploymentServiceClient.DeleteDeploymentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DeploymentServiceClient.DeleteDeployment</c>.
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
        public lro::OperationsSettings DeleteDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000L)),
                sys::TimeSpan.FromMilliseconds(2000L),
                1.1,
                sys::TimeSpan.FromMilliseconds(10000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentServiceClient.SetDeploymentWorkerFlags</c> and <c>DeploymentServiceClient.SetDeploymentWorkerFlagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DeploymentServiceClient.SetDeploymentWorkerFlags</c> and
        /// <c>DeploymentServiceClient.SetDeploymentWorkerFlagsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SetDeploymentWorkerFlagsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentServiceClient.SetDeploymentTags</c> and <c>DeploymentServiceClient.SetDeploymentTagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DeploymentServiceClient.SetDeploymentTags</c> and
        /// <c>DeploymentServiceClient.SetDeploymentTagsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SetDeploymentTagsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentServiceClient.SetDeploymentWorkerCapacities</c> and <c>DeploymentServiceClient.SetDeploymentWorkerCapacitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DeploymentServiceClient.SetDeploymentWorkerCapacities</c> and
        /// <c>DeploymentServiceClient.SetDeploymentWorkerCapacitiesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SetDeploymentWorkerCapacitiesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentServiceClient.SetDeploymentWorkerRateLimits</c> and <c>DeploymentServiceClient.SetDeploymentWorkerRateLimitsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DeploymentServiceClient.SetDeploymentWorkerRateLimits</c> and
        /// <c>DeploymentServiceClient.SetDeploymentWorkerRateLimitsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SetDeploymentWorkerRateLimitsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="DeploymentServiceSettings"/> object.</returns>
        public DeploymentServiceSettings Clone() => new DeploymentServiceSettings(this);
    }

    /// <summary>
    /// DeploymentService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DeploymentServiceClient
    {
        /// <summary>
        /// The default endpoint for the DeploymentService service, which is a host of "platform.api.improbable.io" and a port of 443.
        /// </summary>
        public static ispc::PlatformApiEndpoint DefaultEndpoint { get; } = new ispc::PlatformApiEndpoint("platform.api.improbable.io", 443);

        /// <summary>
        /// Synchronously creates a <see cref="DeploymentServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application auto-detected credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ispc::PlatformApiEndpoint"/>.</param>
        /// <param name="credentials">Optional, most likely a <see cref="ispc::PlatformRefreshTokenCredential"/>.</param>
        /// <param name="settings">Optional <see cref="DeploymentServiceSettings"/>.</param>
        /// <returns>The created <see cref="DeploymentServiceClient"/>.</returns>
        public static DeploymentServiceClient Create(ispc::PlatformApiEndpoint endpoint = null, ispc::PlatformCredential credentials = null, DeploymentServiceSettings settings = null)
        {
            var platformEndpoint = endpoint ?? DefaultEndpoint;
            var platformCredentials = platformEndpoint.Insecure ? null : credentials ?? ispc::PlatformRefreshTokenCredential.AutoDetected;
            grpccore::Channel channel = new ispc::PlatformApiChannel(platformCredentials, platformEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DeploymentServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DeploymentServiceSettings"/>.</param>
        /// <returns>The created <see cref="DeploymentServiceClient"/>.</returns>
        public static DeploymentServiceClient Create(grpccore::Channel channel, DeploymentServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            DeploymentService.DeploymentServiceClient grpcClient = new DeploymentService.DeploymentServiceClient(channel);
            return new DeploymentServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// The underlying gRPC DeploymentService client.
        /// </summary>
        public virtual DeploymentService.DeploymentServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
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
        /// A pageable asynchronous sequence of <see cref="Deployment"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(
            ListDeploymentsRequest request,
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
        /// A pageable sequence of <see cref="Deployment"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(
            ListDeploymentsRequest request,
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetDeploymentResponse> GetDeploymentAsync(
            GetDeploymentRequest request,
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
        public virtual stt::Task<GetDeploymentResponse> GetDeploymentAsync(
            GetDeploymentRequest request,
            st::CancellationToken cancellationToken) => GetDeploymentAsync(
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
        public virtual GetDeploymentResponse GetDeployment(
            GetDeploymentRequest request,
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetDeploymentResponse> GetRunningDeploymentByNameAsync(
            GetRunningDeploymentByNameRequest request,
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
        public virtual stt::Task<GetDeploymentResponse> GetRunningDeploymentByNameAsync(
            GetRunningDeploymentByNameRequest request,
            st::CancellationToken cancellationToken) => GetRunningDeploymentByNameAsync(
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
        public virtual GetDeploymentResponse GetRunningDeploymentByName(
            GetRunningDeploymentByNameRequest request,
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Deployment, CreateDeploymentMetadata>> CreateDeploymentAsync(
            CreateDeploymentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDeploymentAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Deployment, CreateDeploymentMetadata>> PollOnceCreateDeploymentAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Deployment, CreateDeploymentMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateDeploymentOperationsClient,
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
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Deployment, CreateDeploymentMetadata> CreateDeployment(
            CreateDeploymentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateDeployment</c>.
        /// </summary>
        public virtual lro::OperationsClient CreateDeploymentOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDeployment</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Deployment, CreateDeploymentMetadata> PollOnceCreateDeployment(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Deployment, CreateDeploymentMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateDeploymentOperationsClient,
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
        public virtual stt::Task<lro::Operation<Deployment, DeleteDeploymentMetadata>> DeleteDeploymentAsync(
            DeleteDeploymentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDeploymentAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Deployment, DeleteDeploymentMetadata>> PollOnceDeleteDeploymentAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Deployment, DeleteDeploymentMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                DeleteDeploymentOperationsClient,
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
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Deployment, DeleteDeploymentMetadata> DeleteDeployment(
            DeleteDeploymentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>DeleteDeployment</c>.
        /// </summary>
        public virtual lro::OperationsClient DeleteDeploymentOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDeployment</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Deployment, DeleteDeploymentMetadata> PollOnceDeleteDeployment(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Deployment, DeleteDeploymentMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                DeleteDeploymentOperationsClient,
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
        public virtual stt::Task<SetDeploymentWorkerFlagsResponse> SetDeploymentWorkerFlagsAsync(
            SetDeploymentWorkerFlagsRequest request,
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
        public virtual stt::Task<SetDeploymentWorkerFlagsResponse> SetDeploymentWorkerFlagsAsync(
            SetDeploymentWorkerFlagsRequest request,
            st::CancellationToken cancellationToken) => SetDeploymentWorkerFlagsAsync(
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
        public virtual SetDeploymentWorkerFlagsResponse SetDeploymentWorkerFlags(
            SetDeploymentWorkerFlagsRequest request,
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SetDeploymentTagsResponse> SetDeploymentTagsAsync(
            SetDeploymentTagsRequest request,
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
        public virtual stt::Task<SetDeploymentTagsResponse> SetDeploymentTagsAsync(
            SetDeploymentTagsRequest request,
            st::CancellationToken cancellationToken) => SetDeploymentTagsAsync(
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
        public virtual SetDeploymentTagsResponse SetDeploymentTags(
            SetDeploymentTagsRequest request,
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SetDeploymentWorkerCapacitiesResponse> SetDeploymentWorkerCapacitiesAsync(
            SetDeploymentWorkerCapacitiesRequest request,
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
        public virtual stt::Task<SetDeploymentWorkerCapacitiesResponse> SetDeploymentWorkerCapacitiesAsync(
            SetDeploymentWorkerCapacitiesRequest request,
            st::CancellationToken cancellationToken) => SetDeploymentWorkerCapacitiesAsync(
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
        public virtual SetDeploymentWorkerCapacitiesResponse SetDeploymentWorkerCapacities(
            SetDeploymentWorkerCapacitiesRequest request,
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SetDeploymentWorkerRateLimitsResponse> SetDeploymentWorkerRateLimitsAsync(
            SetDeploymentWorkerRateLimitsRequest request,
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
        public virtual stt::Task<SetDeploymentWorkerRateLimitsResponse> SetDeploymentWorkerRateLimitsAsync(
            SetDeploymentWorkerRateLimitsRequest request,
            st::CancellationToken cancellationToken) => SetDeploymentWorkerRateLimitsAsync(
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
        public virtual SetDeploymentWorkerRateLimitsResponse SetDeploymentWorkerRateLimits(
            SetDeploymentWorkerRateLimitsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// DeploymentService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class DeploymentServiceClientImpl : DeploymentServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> _callListDeployments;
        private readonly gaxgrpc::ApiCall<GetDeploymentRequest, GetDeploymentResponse> _callGetDeployment;
        private readonly gaxgrpc::ApiCall<GetRunningDeploymentByNameRequest, GetDeploymentResponse> _callGetRunningDeploymentByName;
        private readonly gaxgrpc::ApiCall<CreateDeploymentRequest, lro::Operation> _callCreateDeployment;
        private readonly gaxgrpc::ApiCall<DeleteDeploymentRequest, lro::Operation> _callDeleteDeployment;
        private readonly gaxgrpc::ApiCall<SetDeploymentWorkerFlagsRequest, SetDeploymentWorkerFlagsResponse> _callSetDeploymentWorkerFlags;
        private readonly gaxgrpc::ApiCall<SetDeploymentTagsRequest, SetDeploymentTagsResponse> _callSetDeploymentTags;
        private readonly gaxgrpc::ApiCall<SetDeploymentWorkerCapacitiesRequest, SetDeploymentWorkerCapacitiesResponse> _callSetDeploymentWorkerCapacities;
        private readonly gaxgrpc::ApiCall<SetDeploymentWorkerRateLimitsRequest, SetDeploymentWorkerRateLimitsResponse> _callSetDeploymentWorkerRateLimits;

        /// <summary>
        /// Constructs a client wrapper for the DeploymentService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DeploymentServiceSettings"/> used within this client </param>
        public DeploymentServiceClientImpl(DeploymentService.DeploymentServiceClient grpcClient, DeploymentServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DeploymentServiceSettings effectiveSettings = settings ?? DeploymentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateDeploymentOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateDeploymentOperationsSettings);
            DeleteDeploymentOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDeploymentOperationsSettings);
            _callListDeployments = clientHelper.BuildApiCall<ListDeploymentsRequest, ListDeploymentsResponse>(
                GrpcClient.ListDeploymentsAsync, GrpcClient.ListDeployments, effectiveSettings.ListDeploymentsSettings);
            _callGetDeployment = clientHelper.BuildApiCall<GetDeploymentRequest, GetDeploymentResponse>(
                GrpcClient.GetDeploymentAsync, GrpcClient.GetDeployment, effectiveSettings.GetDeploymentSettings);
            _callGetRunningDeploymentByName = clientHelper.BuildApiCall<GetRunningDeploymentByNameRequest, GetDeploymentResponse>(
                GrpcClient.GetRunningDeploymentByNameAsync, GrpcClient.GetRunningDeploymentByName, effectiveSettings.GetRunningDeploymentByNameSettings);
            _callCreateDeployment = clientHelper.BuildApiCall<CreateDeploymentRequest, lro::Operation>(
                GrpcClient.CreateDeploymentAsync, GrpcClient.CreateDeployment, effectiveSettings.CreateDeploymentSettings);
            _callDeleteDeployment = clientHelper.BuildApiCall<DeleteDeploymentRequest, lro::Operation>(
                GrpcClient.DeleteDeploymentAsync, GrpcClient.DeleteDeployment, effectiveSettings.DeleteDeploymentSettings);
            _callSetDeploymentWorkerFlags = clientHelper.BuildApiCall<SetDeploymentWorkerFlagsRequest, SetDeploymentWorkerFlagsResponse>(
                GrpcClient.SetDeploymentWorkerFlagsAsync, GrpcClient.SetDeploymentWorkerFlags, effectiveSettings.SetDeploymentWorkerFlagsSettings);
            _callSetDeploymentTags = clientHelper.BuildApiCall<SetDeploymentTagsRequest, SetDeploymentTagsResponse>(
                GrpcClient.SetDeploymentTagsAsync, GrpcClient.SetDeploymentTags, effectiveSettings.SetDeploymentTagsSettings);
            _callSetDeploymentWorkerCapacities = clientHelper.BuildApiCall<SetDeploymentWorkerCapacitiesRequest, SetDeploymentWorkerCapacitiesResponse>(
                GrpcClient.SetDeploymentWorkerCapacitiesAsync, GrpcClient.SetDeploymentWorkerCapacities, effectiveSettings.SetDeploymentWorkerCapacitiesSettings);
            _callSetDeploymentWorkerRateLimits = clientHelper.BuildApiCall<SetDeploymentWorkerRateLimitsRequest, SetDeploymentWorkerRateLimitsResponse>(
                GrpcClient.SetDeploymentWorkerRateLimitsAsync, GrpcClient.SetDeploymentWorkerRateLimits, effectiveSettings.SetDeploymentWorkerRateLimitsSettings);
            Modify_ApiCall(ref _callListDeployments);
            Modify_ListDeploymentsApiCall(ref _callListDeployments);
            Modify_ApiCall(ref _callGetDeployment);
            Modify_GetDeploymentApiCall(ref _callGetDeployment);
            Modify_ApiCall(ref _callGetRunningDeploymentByName);
            Modify_GetRunningDeploymentByNameApiCall(ref _callGetRunningDeploymentByName);
            Modify_ApiCall(ref _callCreateDeployment);
            Modify_CreateDeploymentApiCall(ref _callCreateDeployment);
            Modify_ApiCall(ref _callDeleteDeployment);
            Modify_DeleteDeploymentApiCall(ref _callDeleteDeployment);
            Modify_ApiCall(ref _callSetDeploymentWorkerFlags);
            Modify_SetDeploymentWorkerFlagsApiCall(ref _callSetDeploymentWorkerFlags);
            Modify_ApiCall(ref _callSetDeploymentTags);
            Modify_SetDeploymentTagsApiCall(ref _callSetDeploymentTags);
            Modify_ApiCall(ref _callSetDeploymentWorkerCapacities);
            Modify_SetDeploymentWorkerCapacitiesApiCall(ref _callSetDeploymentWorkerCapacities);
            Modify_ApiCall(ref _callSetDeploymentWorkerRateLimits);
            Modify_SetDeploymentWorkerRateLimitsApiCall(ref _callSetDeploymentWorkerRateLimits);
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
        partial void Modify_ListDeploymentsApiCall(ref gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> call);
        partial void Modify_GetDeploymentApiCall(ref gaxgrpc::ApiCall<GetDeploymentRequest, GetDeploymentResponse> call);
        partial void Modify_GetRunningDeploymentByNameApiCall(ref gaxgrpc::ApiCall<GetRunningDeploymentByNameRequest, GetDeploymentResponse> call);
        partial void Modify_CreateDeploymentApiCall(ref gaxgrpc::ApiCall<CreateDeploymentRequest, lro::Operation> call);
        partial void Modify_DeleteDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteDeploymentRequest, lro::Operation> call);
        partial void Modify_SetDeploymentWorkerFlagsApiCall(ref gaxgrpc::ApiCall<SetDeploymentWorkerFlagsRequest, SetDeploymentWorkerFlagsResponse> call);
        partial void Modify_SetDeploymentTagsApiCall(ref gaxgrpc::ApiCall<SetDeploymentTagsRequest, SetDeploymentTagsResponse> call);
        partial void Modify_SetDeploymentWorkerCapacitiesApiCall(ref gaxgrpc::ApiCall<SetDeploymentWorkerCapacitiesRequest, SetDeploymentWorkerCapacitiesResponse> call);
        partial void Modify_SetDeploymentWorkerRateLimitsApiCall(ref gaxgrpc::ApiCall<SetDeploymentWorkerRateLimitsRequest, SetDeploymentWorkerRateLimitsResponse> call);
        partial void OnConstruction(DeploymentService.DeploymentServiceClient grpcClient, DeploymentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC DeploymentService client.
        /// </summary>
        public override DeploymentService.DeploymentServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListDeploymentsRequest(ref ListDeploymentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetDeploymentRequest(ref GetDeploymentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetRunningDeploymentByNameRequest(ref GetRunningDeploymentByNameRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateDeploymentRequest(ref CreateDeploymentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteDeploymentRequest(ref DeleteDeploymentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetDeploymentWorkerFlagsRequest(ref SetDeploymentWorkerFlagsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetDeploymentTagsRequest(ref SetDeploymentTagsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetDeploymentWorkerCapacitiesRequest(ref SetDeploymentWorkerCapacitiesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetDeploymentWorkerRateLimitsRequest(ref SetDeploymentWorkerRateLimitsRequest request, ref gaxgrpc::CallSettings settings);

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
        /// A pageable asynchronous sequence of <see cref="Deployment"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(
            ListDeploymentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
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
        /// A pageable sequence of <see cref="Deployment"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(
            ListDeploymentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
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
        public override stt::Task<GetDeploymentResponse> GetDeploymentAsync(
            GetDeploymentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Async(request, callSettings);
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
        public override GetDeploymentResponse GetDeployment(
            GetDeploymentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Sync(request, callSettings);
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
        public override stt::Task<GetDeploymentResponse> GetRunningDeploymentByNameAsync(
            GetRunningDeploymentByNameRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRunningDeploymentByNameRequest(ref request, ref callSettings);
            return _callGetRunningDeploymentByName.Async(request, callSettings);
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
        public override GetDeploymentResponse GetRunningDeploymentByName(
            GetRunningDeploymentByNameRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRunningDeploymentByNameRequest(ref request, ref callSettings);
            return _callGetRunningDeploymentByName.Sync(request, callSettings);
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
        public override async stt::Task<lro::Operation<Deployment, CreateDeploymentMetadata>> CreateDeploymentAsync(
            CreateDeploymentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, CreateDeploymentMetadata>(
                await _callCreateDeployment.Async(request, callSettings).ConfigureAwait(false), CreateDeploymentOperationsClient);
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
        public override lro::Operation<Deployment, CreateDeploymentMetadata> CreateDeployment(
            CreateDeploymentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, CreateDeploymentMetadata>(
                _callCreateDeployment.Sync(request, callSettings), CreateDeploymentOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateDeployment</c>.
        /// </summary>
        public override lro::OperationsClient CreateDeploymentOperationsClient { get; }

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
        public override async stt::Task<lro::Operation<Deployment, DeleteDeploymentMetadata>> DeleteDeploymentAsync(
            DeleteDeploymentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, DeleteDeploymentMetadata>(
                await _callDeleteDeployment.Async(request, callSettings).ConfigureAwait(false), DeleteDeploymentOperationsClient);
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
        public override lro::Operation<Deployment, DeleteDeploymentMetadata> DeleteDeployment(
            DeleteDeploymentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, DeleteDeploymentMetadata>(
                _callDeleteDeployment.Sync(request, callSettings), DeleteDeploymentOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>DeleteDeployment</c>.
        /// </summary>
        public override lro::OperationsClient DeleteDeploymentOperationsClient { get; }

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
        public override stt::Task<SetDeploymentWorkerFlagsResponse> SetDeploymentWorkerFlagsAsync(
            SetDeploymentWorkerFlagsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeploymentWorkerFlagsRequest(ref request, ref callSettings);
            return _callSetDeploymentWorkerFlags.Async(request, callSettings);
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
        public override SetDeploymentWorkerFlagsResponse SetDeploymentWorkerFlags(
            SetDeploymentWorkerFlagsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeploymentWorkerFlagsRequest(ref request, ref callSettings);
            return _callSetDeploymentWorkerFlags.Sync(request, callSettings);
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
        public override stt::Task<SetDeploymentTagsResponse> SetDeploymentTagsAsync(
            SetDeploymentTagsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeploymentTagsRequest(ref request, ref callSettings);
            return _callSetDeploymentTags.Async(request, callSettings);
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
        public override SetDeploymentTagsResponse SetDeploymentTags(
            SetDeploymentTagsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeploymentTagsRequest(ref request, ref callSettings);
            return _callSetDeploymentTags.Sync(request, callSettings);
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
        public override stt::Task<SetDeploymentWorkerCapacitiesResponse> SetDeploymentWorkerCapacitiesAsync(
            SetDeploymentWorkerCapacitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeploymentWorkerCapacitiesRequest(ref request, ref callSettings);
            return _callSetDeploymentWorkerCapacities.Async(request, callSettings);
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
        public override SetDeploymentWorkerCapacitiesResponse SetDeploymentWorkerCapacities(
            SetDeploymentWorkerCapacitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeploymentWorkerCapacitiesRequest(ref request, ref callSettings);
            return _callSetDeploymentWorkerCapacities.Sync(request, callSettings);
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
        public override stt::Task<SetDeploymentWorkerRateLimitsResponse> SetDeploymentWorkerRateLimitsAsync(
            SetDeploymentWorkerRateLimitsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeploymentWorkerRateLimitsRequest(ref request, ref callSettings);
            return _callSetDeploymentWorkerRateLimits.Async(request, callSettings);
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
        public override SetDeploymentWorkerRateLimitsResponse SetDeploymentWorkerRateLimits(
            SetDeploymentWorkerRateLimitsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDeploymentWorkerRateLimitsRequest(ref request, ref callSettings);
            return _callSetDeploymentWorkerRateLimits.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListDeploymentsRequest : gaxgrpc::IPageRequest { }
    public partial class ListDeploymentsResponse : gaxgrpc::IPageResponse<Deployment>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Deployment> GetEnumerator() => Deployments.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class DeploymentService
    {
        public partial class DeploymentServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
