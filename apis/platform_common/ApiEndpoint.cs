// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using System;
using Google.Api.Gax;

namespace Improbable.SpatialOS.Platform.Common {
    /// <summary>
    ///     Settings specifying a service endpoint in the form of a host name and port.
    ///     This class is immutable and thread-safe.
    /// </summary>
    public sealed class PlatformApiEndpoint : IEquatable<PlatformApiEndpoint> {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PlatformApiEndpoint" /> class.
        ///     Creates a new endpoint with the given host and port.
        /// </summary>
        /// <param name="host">The host name to connect to. Must not be null or empty.</param>
        /// <param name="port">The port to connect to, in the range 1 to 65535 inclusive.</param>
        /// <param name="insecure">
        ///     Whether the connection is encrypted or not. For unencrypted connections no authentication data
        ///     is sent.
        /// </param>
        public PlatformApiEndpoint(string host, int port, bool insecure = false) {
            Host = GaxPreconditions.CheckNotNullOrEmpty(host, nameof(host));
            Port = GaxPreconditions.CheckArgumentRange(port, nameof(port), 1, 65535);
            Insecure = insecure;
        }

        /// <summary>
        ///     The host name to connect to. Must not be null or empty.
        /// </summary>
        public string Host { get; }

        /// <summary>
        ///     The port to connect to, in the range 1 to 65535 inclusive.
        /// </summary>
        public int Port { get; }

        /// <summary>
        ///     Whether the connection is encrypted or not. For unencrypted connections no authentication data
        ///     is sent.
        /// </summary>
        public bool Insecure { get; }

        /// <summary>
        ///     Determines equality between this endpoint and <paramref name="other" />.
        /// </summary>
        /// <param name="other">The object to compare with this one.</param>
        /// <returns>
        ///     <c>true</c> if <paramref name="other" /> is a <see cref="PlatformApiEndpoint" />
        ///     with the same host and port; <c>false</c> otherwise.
        /// </returns>
        public bool Equals(PlatformApiEndpoint other) {
            return other != null && other.Host == Host && other.Port == Port && other.Insecure == Insecure;
        }

        /// <summary>
        ///     Creates a new endpoint with the same port but the given host.
        /// </summary>
        /// <param name="host">The host name to connect to. Must not be null or empty.</param>
        /// <returns>A new endpoint with the same port and the specified host.</returns>
        public PlatformApiEndpoint WithHost(string host) {
            return new PlatformApiEndpoint(host, Port);
        }

        /// <summary>
        ///     Creates a new endpoint with the same host but the given port.
        /// </summary>
        /// <param name="port">The port to connect to, in the range 1 to 65535 inclusive.</param>
        /// <returns>A new endpoint with the same host and the specified port.</returns>
        public PlatformApiEndpoint WithPort(int port) {
            return new PlatformApiEndpoint(Host, port);
        }

        /// <summary>
        ///     Returns this endpoint's data in the format "host:port".
        /// </summary>
        /// <returns>This endpoint's data in the format "host:port".</returns>
        public override string ToString() {
            return $"{Host}:{Port}";
        }

        /// <summary>
        ///     Determines equality between this object and <paramref name="obj" />.
        /// </summary>
        /// <param name="obj">The object to compare with this one.</param>
        /// <returns>
        ///     <c>true</c> if <paramref name="obj" /> is a <see cref="PlatformApiEndpoint" />
        ///     with the same host and port; <c>false</c> otherwise.
        /// </returns>
        public override bool Equals(object obj) {
            return Equals(obj as PlatformApiEndpoint);
        }

        /// <summary>
        ///     Returns a hash code for this object, consistent with <see cref="Equals(PlatformApiEndpoint)" />.
        /// </summary>
        /// <returns>A hash code for this object.</returns>
        public override int GetHashCode() {
            return unchecked(Host.GetHashCode() * 31 + Port + Insecure.GetHashCode());
        }
    }
}