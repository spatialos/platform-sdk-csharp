// Copyright 2017, Improbable Worlds Ltd rights reserved.
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

namespace Improbable.SpatialOS.PlayerAuth.V2Alpha1
{
    /// <summary>
    /// Settings for a <see cref="PlayerAuthServiceClient"/>.
    /// </summary>
    public sealed partial class PlayerAuthServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="PlayerAuthServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="PlayerAuthServiceSettings"/>.
        /// </returns>
        public static PlayerAuthServiceSettings GetDefault() => new PlayerAuthServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PlayerAuthServiceSettings"/> object with default settings.
        /// </summary>
        public PlayerAuthServiceSettings() { }

        private PlayerAuthServiceSettings(PlayerAuthServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateLoginTokenSettings = existing.CreateLoginTokenSettings;
            CreatePlayerIdentityTokenSettings = existing.CreatePlayerIdentityTokenSettings;
            DecodePlayerIdentityTokenSettings = existing.DecodePlayerIdentityTokenSettings;
            CreateDevelopmentAuthenticationTokenSettings = existing.CreateDevelopmentAuthenticationTokenSettings;
            GetDevelopmentAuthenticationTokenSettings = existing.GetDevelopmentAuthenticationTokenSettings;
            ListDevelopmentAuthenticationTokensSettings = existing.ListDevelopmentAuthenticationTokensSettings;
            UpdateDevelopmentAuthenticationTokenSettings = existing.UpdateDevelopmentAuthenticationTokenSettings;
            ExpireDevelopmentAuthenticationTokenSettings = existing.ExpireDevelopmentAuthenticationTokenSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PlayerAuthServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="PlayerAuthServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="PlayerAuthServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="PlayerAuthServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="PlayerAuthServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="PlayerAuthServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="PlayerAuthServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="PlayerAuthServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="PlayerAuthServiceClient"/> RPC methods is defined as:
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
        /// <c>PlayerAuthServiceClient.CreateLoginToken</c> and <c>PlayerAuthServiceClient.CreateLoginTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PlayerAuthServiceClient.CreateLoginToken</c> and
        /// <c>PlayerAuthServiceClient.CreateLoginTokenAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateLoginTokenSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlayerAuthServiceClient.CreatePlayerIdentityToken</c> and <c>PlayerAuthServiceClient.CreatePlayerIdentityTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PlayerAuthServiceClient.CreatePlayerIdentityToken</c> and
        /// <c>PlayerAuthServiceClient.CreatePlayerIdentityTokenAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreatePlayerIdentityTokenSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlayerAuthServiceClient.DecodePlayerIdentityToken</c> and <c>PlayerAuthServiceClient.DecodePlayerIdentityTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PlayerAuthServiceClient.DecodePlayerIdentityToken</c> and
        /// <c>PlayerAuthServiceClient.DecodePlayerIdentityTokenAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DecodePlayerIdentityTokenSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlayerAuthServiceClient.CreateDevelopmentAuthenticationToken</c> and <c>PlayerAuthServiceClient.CreateDevelopmentAuthenticationTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PlayerAuthServiceClient.CreateDevelopmentAuthenticationToken</c> and
        /// <c>PlayerAuthServiceClient.CreateDevelopmentAuthenticationTokenAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateDevelopmentAuthenticationTokenSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlayerAuthServiceClient.GetDevelopmentAuthenticationToken</c> and <c>PlayerAuthServiceClient.GetDevelopmentAuthenticationTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PlayerAuthServiceClient.GetDevelopmentAuthenticationToken</c> and
        /// <c>PlayerAuthServiceClient.GetDevelopmentAuthenticationTokenAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetDevelopmentAuthenticationTokenSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlayerAuthServiceClient.ListDevelopmentAuthenticationTokens</c> and <c>PlayerAuthServiceClient.ListDevelopmentAuthenticationTokensAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PlayerAuthServiceClient.ListDevelopmentAuthenticationTokens</c> and
        /// <c>PlayerAuthServiceClient.ListDevelopmentAuthenticationTokensAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListDevelopmentAuthenticationTokensSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlayerAuthServiceClient.UpdateDevelopmentAuthenticationToken</c> and <c>PlayerAuthServiceClient.UpdateDevelopmentAuthenticationTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PlayerAuthServiceClient.UpdateDevelopmentAuthenticationToken</c> and
        /// <c>PlayerAuthServiceClient.UpdateDevelopmentAuthenticationTokenAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateDevelopmentAuthenticationTokenSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlayerAuthServiceClient.ExpireDevelopmentAuthenticationToken</c> and <c>PlayerAuthServiceClient.ExpireDevelopmentAuthenticationTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PlayerAuthServiceClient.ExpireDevelopmentAuthenticationToken</c> and
        /// <c>PlayerAuthServiceClient.ExpireDevelopmentAuthenticationTokenAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ExpireDevelopmentAuthenticationTokenSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="PlayerAuthServiceSettings"/> object.</returns>
        public PlayerAuthServiceSettings Clone() => new PlayerAuthServiceSettings(this);
    }

    /// <summary>
    /// PlayerAuthService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class PlayerAuthServiceClient
    {
        /// <summary>
        /// The default endpoint for the PlayerAuthService service, which is a host of "playerauth.api.improbable.io" and a port of 443.
        /// </summary>
        public static ispc::PlatformApiEndpoint DefaultEndpoint { get; } = new ispc::PlatformApiEndpoint("playerauth.api.improbable.io", 443);

        /// <summary>
        /// Synchronously creates a <see cref="PlayerAuthServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application auto-detected credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ispc::PlatformApiEndpoint"/>.</param>
        /// <param name="credentials">Optional, most likely a <see cref="ispc::PlatformRefreshTokenCredential"/>.</param>
        /// <param name="settings">Optional <see cref="PlayerAuthServiceSettings"/>.</param>
        /// <returns>The created <see cref="PlayerAuthServiceClient"/>.</returns>
        public static PlayerAuthServiceClient Create(ispc::PlatformApiEndpoint endpoint = null, ispc::PlatformCredential credentials = null, PlayerAuthServiceSettings settings = null)
        {
            var platformEndpoint = endpoint ?? DefaultEndpoint;
            var platformCredentials = platformEndpoint.Insecure ? null : credentials ?? ispc::PlatformRefreshTokenCredential.AutoDetected;
            grpccore::Channel channel = new ispc::PlatformApiChannel(platformCredentials, platformEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="PlayerAuthServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="PlayerAuthServiceSettings"/>.</param>
        /// <returns>The created <see cref="PlayerAuthServiceClient"/>.</returns>
        public static PlayerAuthServiceClient Create(grpccore::Channel channel, PlayerAuthServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            PlayerAuthService.PlayerAuthServiceClient grpcClient = new PlayerAuthService.PlayerAuthServiceClient(channel);
            return new PlayerAuthServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// The underlying gRPC PlayerAuthService client.
        /// </summary>
        public virtual PlayerAuthService.PlayerAuthServiceClient GrpcClient
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateLoginTokenResponse> CreateLoginTokenAsync(
            CreateLoginTokenRequest request,
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
        public virtual stt::Task<CreateLoginTokenResponse> CreateLoginTokenAsync(
            CreateLoginTokenRequest request,
            st::CancellationToken cancellationToken) => CreateLoginTokenAsync(
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
        public virtual CreateLoginTokenResponse CreateLoginToken(
            CreateLoginTokenRequest request,
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
        public virtual stt::Task<CreatePlayerIdentityTokenResponse> CreatePlayerIdentityTokenAsync(
            CreatePlayerIdentityTokenRequest request,
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
        public virtual stt::Task<CreatePlayerIdentityTokenResponse> CreatePlayerIdentityTokenAsync(
            CreatePlayerIdentityTokenRequest request,
            st::CancellationToken cancellationToken) => CreatePlayerIdentityTokenAsync(
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
        public virtual CreatePlayerIdentityTokenResponse CreatePlayerIdentityToken(
            CreatePlayerIdentityTokenRequest request,
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
        public virtual stt::Task<DecodePlayerIdentityTokenResponse> DecodePlayerIdentityTokenAsync(
            DecodePlayerIdentityTokenRequest request,
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
        public virtual stt::Task<DecodePlayerIdentityTokenResponse> DecodePlayerIdentityTokenAsync(
            DecodePlayerIdentityTokenRequest request,
            st::CancellationToken cancellationToken) => DecodePlayerIdentityTokenAsync(
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
        public virtual DecodePlayerIdentityTokenResponse DecodePlayerIdentityToken(
            DecodePlayerIdentityTokenRequest request,
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
        public virtual stt::Task<CreateDevelopmentAuthenticationTokenResponse> CreateDevelopmentAuthenticationTokenAsync(
            CreateDevelopmentAuthenticationTokenRequest request,
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
        public virtual stt::Task<CreateDevelopmentAuthenticationTokenResponse> CreateDevelopmentAuthenticationTokenAsync(
            CreateDevelopmentAuthenticationTokenRequest request,
            st::CancellationToken cancellationToken) => CreateDevelopmentAuthenticationTokenAsync(
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
        public virtual CreateDevelopmentAuthenticationTokenResponse CreateDevelopmentAuthenticationToken(
            CreateDevelopmentAuthenticationTokenRequest request,
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
        public virtual stt::Task<GetDevelopmentAuthenticationTokenResponse> GetDevelopmentAuthenticationTokenAsync(
            GetDevelopmentAuthenticationTokenRequest request,
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
        public virtual stt::Task<GetDevelopmentAuthenticationTokenResponse> GetDevelopmentAuthenticationTokenAsync(
            GetDevelopmentAuthenticationTokenRequest request,
            st::CancellationToken cancellationToken) => GetDevelopmentAuthenticationTokenAsync(
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
        public virtual GetDevelopmentAuthenticationTokenResponse GetDevelopmentAuthenticationToken(
            GetDevelopmentAuthenticationTokenRequest request,
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
        /// A pageable asynchronous sequence of <see cref="DevelopmentAuthenticationToken"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDevelopmentAuthenticationTokensResponse, DevelopmentAuthenticationToken> ListDevelopmentAuthenticationTokensAsync(
            ListDevelopmentAuthenticationTokensRequest request,
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
        /// A pageable sequence of <see cref="DevelopmentAuthenticationToken"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListDevelopmentAuthenticationTokensResponse, DevelopmentAuthenticationToken> ListDevelopmentAuthenticationTokens(
            ListDevelopmentAuthenticationTokensRequest request,
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
        public virtual stt::Task<UpdateDevelopmentAuthenticationTokenResponse> UpdateDevelopmentAuthenticationTokenAsync(
            UpdateDevelopmentAuthenticationTokenRequest request,
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
        public virtual stt::Task<UpdateDevelopmentAuthenticationTokenResponse> UpdateDevelopmentAuthenticationTokenAsync(
            UpdateDevelopmentAuthenticationTokenRequest request,
            st::CancellationToken cancellationToken) => UpdateDevelopmentAuthenticationTokenAsync(
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
        public virtual UpdateDevelopmentAuthenticationTokenResponse UpdateDevelopmentAuthenticationToken(
            UpdateDevelopmentAuthenticationTokenRequest request,
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
        public virtual stt::Task<ExpireDevelopmentAuthenticationTokenResponse> ExpireDevelopmentAuthenticationTokenAsync(
            ExpireDevelopmentAuthenticationTokenRequest request,
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
        public virtual stt::Task<ExpireDevelopmentAuthenticationTokenResponse> ExpireDevelopmentAuthenticationTokenAsync(
            ExpireDevelopmentAuthenticationTokenRequest request,
            st::CancellationToken cancellationToken) => ExpireDevelopmentAuthenticationTokenAsync(
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
        public virtual ExpireDevelopmentAuthenticationTokenResponse ExpireDevelopmentAuthenticationToken(
            ExpireDevelopmentAuthenticationTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// PlayerAuthService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class PlayerAuthServiceClientImpl : PlayerAuthServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateLoginTokenRequest, CreateLoginTokenResponse> _callCreateLoginToken;
        private readonly gaxgrpc::ApiCall<CreatePlayerIdentityTokenRequest, CreatePlayerIdentityTokenResponse> _callCreatePlayerIdentityToken;
        private readonly gaxgrpc::ApiCall<DecodePlayerIdentityTokenRequest, DecodePlayerIdentityTokenResponse> _callDecodePlayerIdentityToken;
        private readonly gaxgrpc::ApiCall<CreateDevelopmentAuthenticationTokenRequest, CreateDevelopmentAuthenticationTokenResponse> _callCreateDevelopmentAuthenticationToken;
        private readonly gaxgrpc::ApiCall<GetDevelopmentAuthenticationTokenRequest, GetDevelopmentAuthenticationTokenResponse> _callGetDevelopmentAuthenticationToken;
        private readonly gaxgrpc::ApiCall<ListDevelopmentAuthenticationTokensRequest, ListDevelopmentAuthenticationTokensResponse> _callListDevelopmentAuthenticationTokens;
        private readonly gaxgrpc::ApiCall<UpdateDevelopmentAuthenticationTokenRequest, UpdateDevelopmentAuthenticationTokenResponse> _callUpdateDevelopmentAuthenticationToken;
        private readonly gaxgrpc::ApiCall<ExpireDevelopmentAuthenticationTokenRequest, ExpireDevelopmentAuthenticationTokenResponse> _callExpireDevelopmentAuthenticationToken;

        /// <summary>
        /// Constructs a client wrapper for the PlayerAuthService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PlayerAuthServiceSettings"/> used within this client </param>
        public PlayerAuthServiceClientImpl(PlayerAuthService.PlayerAuthServiceClient grpcClient, PlayerAuthServiceSettings settings)
        {
            GrpcClient = grpcClient;
            PlayerAuthServiceSettings effectiveSettings = settings ?? PlayerAuthServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateLoginToken = clientHelper.BuildApiCall<CreateLoginTokenRequest, CreateLoginTokenResponse>(
                GrpcClient.CreateLoginTokenAsync, GrpcClient.CreateLoginToken, effectiveSettings.CreateLoginTokenSettings);
            _callCreatePlayerIdentityToken = clientHelper.BuildApiCall<CreatePlayerIdentityTokenRequest, CreatePlayerIdentityTokenResponse>(
                GrpcClient.CreatePlayerIdentityTokenAsync, GrpcClient.CreatePlayerIdentityToken, effectiveSettings.CreatePlayerIdentityTokenSettings);
            _callDecodePlayerIdentityToken = clientHelper.BuildApiCall<DecodePlayerIdentityTokenRequest, DecodePlayerIdentityTokenResponse>(
                GrpcClient.DecodePlayerIdentityTokenAsync, GrpcClient.DecodePlayerIdentityToken, effectiveSettings.DecodePlayerIdentityTokenSettings);
            _callCreateDevelopmentAuthenticationToken = clientHelper.BuildApiCall<CreateDevelopmentAuthenticationTokenRequest, CreateDevelopmentAuthenticationTokenResponse>(
                GrpcClient.CreateDevelopmentAuthenticationTokenAsync, GrpcClient.CreateDevelopmentAuthenticationToken, effectiveSettings.CreateDevelopmentAuthenticationTokenSettings);
            _callGetDevelopmentAuthenticationToken = clientHelper.BuildApiCall<GetDevelopmentAuthenticationTokenRequest, GetDevelopmentAuthenticationTokenResponse>(
                GrpcClient.GetDevelopmentAuthenticationTokenAsync, GrpcClient.GetDevelopmentAuthenticationToken, effectiveSettings.GetDevelopmentAuthenticationTokenSettings);
            _callListDevelopmentAuthenticationTokens = clientHelper.BuildApiCall<ListDevelopmentAuthenticationTokensRequest, ListDevelopmentAuthenticationTokensResponse>(
                GrpcClient.ListDevelopmentAuthenticationTokensAsync, GrpcClient.ListDevelopmentAuthenticationTokens, effectiveSettings.ListDevelopmentAuthenticationTokensSettings);
            _callUpdateDevelopmentAuthenticationToken = clientHelper.BuildApiCall<UpdateDevelopmentAuthenticationTokenRequest, UpdateDevelopmentAuthenticationTokenResponse>(
                GrpcClient.UpdateDevelopmentAuthenticationTokenAsync, GrpcClient.UpdateDevelopmentAuthenticationToken, effectiveSettings.UpdateDevelopmentAuthenticationTokenSettings);
            _callExpireDevelopmentAuthenticationToken = clientHelper.BuildApiCall<ExpireDevelopmentAuthenticationTokenRequest, ExpireDevelopmentAuthenticationTokenResponse>(
                GrpcClient.ExpireDevelopmentAuthenticationTokenAsync, GrpcClient.ExpireDevelopmentAuthenticationToken, effectiveSettings.ExpireDevelopmentAuthenticationTokenSettings);
            Modify_ApiCall(ref _callCreateLoginToken);
            Modify_CreateLoginTokenApiCall(ref _callCreateLoginToken);
            Modify_ApiCall(ref _callCreatePlayerIdentityToken);
            Modify_CreatePlayerIdentityTokenApiCall(ref _callCreatePlayerIdentityToken);
            Modify_ApiCall(ref _callDecodePlayerIdentityToken);
            Modify_DecodePlayerIdentityTokenApiCall(ref _callDecodePlayerIdentityToken);
            Modify_ApiCall(ref _callCreateDevelopmentAuthenticationToken);
            Modify_CreateDevelopmentAuthenticationTokenApiCall(ref _callCreateDevelopmentAuthenticationToken);
            Modify_ApiCall(ref _callGetDevelopmentAuthenticationToken);
            Modify_GetDevelopmentAuthenticationTokenApiCall(ref _callGetDevelopmentAuthenticationToken);
            Modify_ApiCall(ref _callListDevelopmentAuthenticationTokens);
            Modify_ListDevelopmentAuthenticationTokensApiCall(ref _callListDevelopmentAuthenticationTokens);
            Modify_ApiCall(ref _callUpdateDevelopmentAuthenticationToken);
            Modify_UpdateDevelopmentAuthenticationTokenApiCall(ref _callUpdateDevelopmentAuthenticationToken);
            Modify_ApiCall(ref _callExpireDevelopmentAuthenticationToken);
            Modify_ExpireDevelopmentAuthenticationTokenApiCall(ref _callExpireDevelopmentAuthenticationToken);
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
        partial void Modify_CreateLoginTokenApiCall(ref gaxgrpc::ApiCall<CreateLoginTokenRequest, CreateLoginTokenResponse> call);
        partial void Modify_CreatePlayerIdentityTokenApiCall(ref gaxgrpc::ApiCall<CreatePlayerIdentityTokenRequest, CreatePlayerIdentityTokenResponse> call);
        partial void Modify_DecodePlayerIdentityTokenApiCall(ref gaxgrpc::ApiCall<DecodePlayerIdentityTokenRequest, DecodePlayerIdentityTokenResponse> call);
        partial void Modify_CreateDevelopmentAuthenticationTokenApiCall(ref gaxgrpc::ApiCall<CreateDevelopmentAuthenticationTokenRequest, CreateDevelopmentAuthenticationTokenResponse> call);
        partial void Modify_GetDevelopmentAuthenticationTokenApiCall(ref gaxgrpc::ApiCall<GetDevelopmentAuthenticationTokenRequest, GetDevelopmentAuthenticationTokenResponse> call);
        partial void Modify_ListDevelopmentAuthenticationTokensApiCall(ref gaxgrpc::ApiCall<ListDevelopmentAuthenticationTokensRequest, ListDevelopmentAuthenticationTokensResponse> call);
        partial void Modify_UpdateDevelopmentAuthenticationTokenApiCall(ref gaxgrpc::ApiCall<UpdateDevelopmentAuthenticationTokenRequest, UpdateDevelopmentAuthenticationTokenResponse> call);
        partial void Modify_ExpireDevelopmentAuthenticationTokenApiCall(ref gaxgrpc::ApiCall<ExpireDevelopmentAuthenticationTokenRequest, ExpireDevelopmentAuthenticationTokenResponse> call);
        partial void OnConstruction(PlayerAuthService.PlayerAuthServiceClient grpcClient, PlayerAuthServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC PlayerAuthService client.
        /// </summary>
        public override PlayerAuthService.PlayerAuthServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateLoginTokenRequest(ref CreateLoginTokenRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreatePlayerIdentityTokenRequest(ref CreatePlayerIdentityTokenRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DecodePlayerIdentityTokenRequest(ref DecodePlayerIdentityTokenRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateDevelopmentAuthenticationTokenRequest(ref CreateDevelopmentAuthenticationTokenRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetDevelopmentAuthenticationTokenRequest(ref GetDevelopmentAuthenticationTokenRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListDevelopmentAuthenticationTokensRequest(ref ListDevelopmentAuthenticationTokensRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateDevelopmentAuthenticationTokenRequest(ref UpdateDevelopmentAuthenticationTokenRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ExpireDevelopmentAuthenticationTokenRequest(ref ExpireDevelopmentAuthenticationTokenRequest request, ref gaxgrpc::CallSettings settings);

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
        public override stt::Task<CreateLoginTokenResponse> CreateLoginTokenAsync(
            CreateLoginTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLoginTokenRequest(ref request, ref callSettings);
            return _callCreateLoginToken.Async(request, callSettings);
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
        public override CreateLoginTokenResponse CreateLoginToken(
            CreateLoginTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLoginTokenRequest(ref request, ref callSettings);
            return _callCreateLoginToken.Sync(request, callSettings);
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
        public override stt::Task<CreatePlayerIdentityTokenResponse> CreatePlayerIdentityTokenAsync(
            CreatePlayerIdentityTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePlayerIdentityTokenRequest(ref request, ref callSettings);
            return _callCreatePlayerIdentityToken.Async(request, callSettings);
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
        public override CreatePlayerIdentityTokenResponse CreatePlayerIdentityToken(
            CreatePlayerIdentityTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePlayerIdentityTokenRequest(ref request, ref callSettings);
            return _callCreatePlayerIdentityToken.Sync(request, callSettings);
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
        public override stt::Task<DecodePlayerIdentityTokenResponse> DecodePlayerIdentityTokenAsync(
            DecodePlayerIdentityTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DecodePlayerIdentityTokenRequest(ref request, ref callSettings);
            return _callDecodePlayerIdentityToken.Async(request, callSettings);
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
        public override DecodePlayerIdentityTokenResponse DecodePlayerIdentityToken(
            DecodePlayerIdentityTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DecodePlayerIdentityTokenRequest(ref request, ref callSettings);
            return _callDecodePlayerIdentityToken.Sync(request, callSettings);
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
        public override stt::Task<CreateDevelopmentAuthenticationTokenResponse> CreateDevelopmentAuthenticationTokenAsync(
            CreateDevelopmentAuthenticationTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDevelopmentAuthenticationTokenRequest(ref request, ref callSettings);
            return _callCreateDevelopmentAuthenticationToken.Async(request, callSettings);
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
        public override CreateDevelopmentAuthenticationTokenResponse CreateDevelopmentAuthenticationToken(
            CreateDevelopmentAuthenticationTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDevelopmentAuthenticationTokenRequest(ref request, ref callSettings);
            return _callCreateDevelopmentAuthenticationToken.Sync(request, callSettings);
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
        public override stt::Task<GetDevelopmentAuthenticationTokenResponse> GetDevelopmentAuthenticationTokenAsync(
            GetDevelopmentAuthenticationTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDevelopmentAuthenticationTokenRequest(ref request, ref callSettings);
            return _callGetDevelopmentAuthenticationToken.Async(request, callSettings);
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
        public override GetDevelopmentAuthenticationTokenResponse GetDevelopmentAuthenticationToken(
            GetDevelopmentAuthenticationTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDevelopmentAuthenticationTokenRequest(ref request, ref callSettings);
            return _callGetDevelopmentAuthenticationToken.Sync(request, callSettings);
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
        /// A pageable asynchronous sequence of <see cref="DevelopmentAuthenticationToken"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDevelopmentAuthenticationTokensResponse, DevelopmentAuthenticationToken> ListDevelopmentAuthenticationTokensAsync(
            ListDevelopmentAuthenticationTokensRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDevelopmentAuthenticationTokensRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDevelopmentAuthenticationTokensRequest, ListDevelopmentAuthenticationTokensResponse, DevelopmentAuthenticationToken>(_callListDevelopmentAuthenticationTokens, request, callSettings);
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
        /// A pageable sequence of <see cref="DevelopmentAuthenticationToken"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListDevelopmentAuthenticationTokensResponse, DevelopmentAuthenticationToken> ListDevelopmentAuthenticationTokens(
            ListDevelopmentAuthenticationTokensRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDevelopmentAuthenticationTokensRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDevelopmentAuthenticationTokensRequest, ListDevelopmentAuthenticationTokensResponse, DevelopmentAuthenticationToken>(_callListDevelopmentAuthenticationTokens, request, callSettings);
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
        public override stt::Task<UpdateDevelopmentAuthenticationTokenResponse> UpdateDevelopmentAuthenticationTokenAsync(
            UpdateDevelopmentAuthenticationTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDevelopmentAuthenticationTokenRequest(ref request, ref callSettings);
            return _callUpdateDevelopmentAuthenticationToken.Async(request, callSettings);
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
        public override UpdateDevelopmentAuthenticationTokenResponse UpdateDevelopmentAuthenticationToken(
            UpdateDevelopmentAuthenticationTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDevelopmentAuthenticationTokenRequest(ref request, ref callSettings);
            return _callUpdateDevelopmentAuthenticationToken.Sync(request, callSettings);
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
        public override stt::Task<ExpireDevelopmentAuthenticationTokenResponse> ExpireDevelopmentAuthenticationTokenAsync(
            ExpireDevelopmentAuthenticationTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExpireDevelopmentAuthenticationTokenRequest(ref request, ref callSettings);
            return _callExpireDevelopmentAuthenticationToken.Async(request, callSettings);
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
        public override ExpireDevelopmentAuthenticationTokenResponse ExpireDevelopmentAuthenticationToken(
            ExpireDevelopmentAuthenticationTokenRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExpireDevelopmentAuthenticationTokenRequest(ref request, ref callSettings);
            return _callExpireDevelopmentAuthenticationToken.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListDevelopmentAuthenticationTokensRequest : gaxgrpc::IPageRequest { }
    public partial class ListDevelopmentAuthenticationTokensResponse : gaxgrpc::IPageResponse<DevelopmentAuthenticationToken>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<DevelopmentAuthenticationToken> GetEnumerator() => DevelopmentAuthenticationTokens.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
