// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Load Balancer Type. </summary>
    public readonly partial struct LoadBalancerType : IEquatable<LoadBalancerType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="LoadBalancerType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LoadBalancerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PublicIpValue = "PublicIp";
        private const string InternalLoadBalancerValue = "InternalLoadBalancer";

        /// <summary> PublicIp. </summary>
        public static LoadBalancerType PublicIp { get; } = new LoadBalancerType(PublicIpValue);
        /// <summary> InternalLoadBalancer. </summary>
        public static LoadBalancerType InternalLoadBalancer { get; } = new LoadBalancerType(InternalLoadBalancerValue);
        /// <summary> Determines if two <see cref="LoadBalancerType"/> values are the same. </summary>
        public static bool operator ==(LoadBalancerType left, LoadBalancerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LoadBalancerType"/> values are not the same. </summary>
        public static bool operator !=(LoadBalancerType left, LoadBalancerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LoadBalancerType"/>. </summary>
        public static implicit operator LoadBalancerType(string value) => new LoadBalancerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LoadBalancerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LoadBalancerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
