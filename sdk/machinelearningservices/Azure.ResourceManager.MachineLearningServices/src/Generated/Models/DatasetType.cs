// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The DatasetType. </summary>
    public readonly partial struct DatasetType : IEquatable<DatasetType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DatasetType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatasetType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SimpleValue = "Simple";
        private const string DataflowValue = "Dataflow";

        /// <summary> Simple. </summary>
        public static DatasetType Simple { get; } = new DatasetType(SimpleValue);
        /// <summary> Dataflow. </summary>
        public static DatasetType Dataflow { get; } = new DatasetType(DataflowValue);
        /// <summary> Determines if two <see cref="DatasetType"/> values are the same. </summary>
        public static bool operator ==(DatasetType left, DatasetType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatasetType"/> values are not the same. </summary>
        public static bool operator !=(DatasetType left, DatasetType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DatasetType"/>. </summary>
        public static implicit operator DatasetType(string value) => new DatasetType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatasetType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatasetType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
