// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> State of endpoint provisioning. </summary>
    public readonly partial struct EndpointProvisioningState : IEquatable<EndpointProvisioningState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EndpointProvisioningState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EndpointProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string UpdatingValue = "Updating";
        private const string CanceledValue = "Canceled";

        /// <summary> Creating. </summary>
        public static EndpointProvisioningState Creating { get; } = new EndpointProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static EndpointProvisioningState Deleting { get; } = new EndpointProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static EndpointProvisioningState Succeeded { get; } = new EndpointProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static EndpointProvisioningState Failed { get; } = new EndpointProvisioningState(FailedValue);
        /// <summary> Updating. </summary>
        public static EndpointProvisioningState Updating { get; } = new EndpointProvisioningState(UpdatingValue);
        /// <summary> Canceled. </summary>
        public static EndpointProvisioningState Canceled { get; } = new EndpointProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="EndpointProvisioningState"/> values are the same. </summary>
        public static bool operator ==(EndpointProvisioningState left, EndpointProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EndpointProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(EndpointProvisioningState left, EndpointProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EndpointProvisioningState"/>. </summary>
        public static implicit operator EndpointProvisioningState(string value) => new EndpointProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EndpointProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EndpointProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
