// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Enum to determine docker specification type. Must be either Build or Image. </summary>
    public readonly partial struct DockerSpecificationType : IEquatable<DockerSpecificationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DockerSpecificationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DockerSpecificationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BuildValue = "Build";
        private const string ImageValue = "Image";

        /// <summary> Build. </summary>
        public static DockerSpecificationType Build { get; } = new DockerSpecificationType(BuildValue);
        /// <summary> Image. </summary>
        public static DockerSpecificationType Image { get; } = new DockerSpecificationType(ImageValue);
        /// <summary> Determines if two <see cref="DockerSpecificationType"/> values are the same. </summary>
        public static bool operator ==(DockerSpecificationType left, DockerSpecificationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DockerSpecificationType"/> values are not the same. </summary>
        public static bool operator !=(DockerSpecificationType left, DockerSpecificationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DockerSpecificationType"/>. </summary>
        public static implicit operator DockerSpecificationType(string value) => new DockerSpecificationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DockerSpecificationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DockerSpecificationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
