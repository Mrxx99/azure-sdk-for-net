// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class LabelingJobImageProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AnnotationType))
            {
                writer.WritePropertyName("annotationType");
                writer.WriteStringValue(AnnotationType.Value.ToString());
            }
            writer.WritePropertyName("mediaType");
            writer.WriteStringValue(MediaType.ToString());
            writer.WriteEndObject();
        }

        internal static LabelingJobImageProperties DeserializeLabelingJobImageProperties(JsonElement element)
        {
            Optional<ImageAnnotationType> annotationType = default;
            MediaType mediaType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("annotationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    annotationType = new ImageAnnotationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mediaType"))
                {
                    mediaType = new MediaType(property.Value.GetString());
                    continue;
                }
            }
            return new LabelingJobImageProperties(mediaType, Optional.ToNullable(annotationType));
        }
    }
}
