// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class Cron : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone");
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(Expression))
            {
                writer.WritePropertyName("expression");
                writer.WriteStringValue(Expression);
            }
            writer.WriteEndObject();
        }

        internal static Cron DeserializeCron(JsonElement element)
        {
            Optional<string> startTime = default;
            Optional<string> timeZone = default;
            Optional<string> expression = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeZone"))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expression"))
                {
                    expression = property.Value.GetString();
                    continue;
                }
            }
            return new Cron(startTime.Value, timeZone.Value, expression.Value);
        }
    }
}
