// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using System;

namespace Improbable.SpatialOS.Platform
{
    /// <summary>
    /// This exception indicates that the user didn't provide a user credential (required for a secure connection).
    /// </summary>
    public class NoCredentialInSecureConnectionException : Exception
    {
        /// <summary>
        /// A constructor with default error text.
        /// </summary>
        public NoCredentialInSecureConnectionException() : base(
            "A valid user credential must be present for a secure connection.")
        { }
    }

    /// <summary>
    /// This exception indicates that the user didn't provide a valid refresh token with AutoDetected mode.
    /// </summary>
    public class NoRefreshTokenFoundException : Exception
    {
        /// <summary>
        /// A constructor that allows passing in additional error text.
        /// </summary>
        public NoRefreshTokenFoundException(string additionalMessage) : base(
            $"No refresh token found locally; {additionalMessage}")
        { }
    }
}