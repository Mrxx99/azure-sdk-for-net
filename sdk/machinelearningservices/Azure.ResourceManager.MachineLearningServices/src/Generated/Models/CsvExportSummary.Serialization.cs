// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class CsvExportSummary : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("format");
            writer.WriteStringValue(Format.ToString());
            writer.WriteEndObject();
        }

        internal static CsvExportSummary DeserializeCsvExportSummary(JsonElement element)
        {
            Optional<string> containerName = default;
            Optional<string> snapshotPath = default;
            Optional<DateTimeOffset> endTimeUtc = default;
            Optional<long> exportedRowCount = default;
            ExportFormatType format = default;
            Optional<string> labelingJobId = default;
            Optional<DateTimeOffset> startTimeUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerName"))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("snapshotPath"))
                {
                    snapshotPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("exportedRowCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    exportedRowCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("format"))
                {
                    format = new ExportFormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("labelingJobId"))
                {
                    labelingJobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new CsvExportSummary(Optional.ToNullable(endTimeUtc), Optional.ToNullable(exportedRowCount), format, labelingJobId.Value, Optional.ToNullable(startTimeUtc), containerName.Value, snapshotPath.Value);
        }
    }
}
