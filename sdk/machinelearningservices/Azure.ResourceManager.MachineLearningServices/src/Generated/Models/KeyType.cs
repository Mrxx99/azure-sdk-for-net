// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The KeyType. </summary>
    public readonly partial struct KeyType : IEquatable<KeyType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="KeyType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string SecondaryValue = "Secondary";

        /// <summary> Primary. </summary>
        public static KeyType Primary { get; } = new KeyType(PrimaryValue);
        /// <summary> Secondary. </summary>
        public static KeyType Secondary { get; } = new KeyType(SecondaryValue);
        /// <summary> Determines if two <see cref="KeyType"/> values are the same. </summary>
        public static bool operator ==(KeyType left, KeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyType"/> values are not the same. </summary>
        public static bool operator !=(KeyType left, KeyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KeyType"/>. </summary>
        public static implicit operator KeyType(string value) => new KeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
