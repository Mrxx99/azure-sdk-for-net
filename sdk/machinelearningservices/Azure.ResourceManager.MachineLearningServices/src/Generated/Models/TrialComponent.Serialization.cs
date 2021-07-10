// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class TrialComponent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CodeId))
            {
                writer.WritePropertyName("codeId");
                writer.WriteStringValue(CodeId);
            }
            writer.WritePropertyName("command");
            writer.WriteStringValue(Command);
            if (Optional.IsDefined(Distribution))
            {
                writer.WritePropertyName("distribution");
                writer.WriteObjectValue(Distribution);
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId");
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(InputDataBindings))
            {
                writer.WritePropertyName("inputDataBindings");
                writer.WriteStartObject();
                foreach (var item in InputDataBindings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(OutputDataBindings))
            {
                writer.WritePropertyName("outputDataBindings");
                writer.WriteStartObject();
                foreach (var item in OutputDataBindings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout");
                writer.WriteStringValue(Timeout.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static TrialComponent DeserializeTrialComponent(JsonElement element)
        {
            Optional<string> codeId = default;
            string command = default;
            Optional<DistributionConfiguration> distribution = default;
            Optional<string> environmentId = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<IDictionary<string, InputDataBinding>> inputDataBindings = default;
            Optional<IDictionary<string, OutputDataBinding>> outputDataBindings = default;
            Optional<TimeSpan> timeout = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeId"))
                {
                    codeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("command"))
                {
                    command = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distribution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    distribution = DistributionConfiguration.DeserializeDistributionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentId"))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("inputDataBindings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, InputDataBinding> dictionary = new Dictionary<string, InputDataBinding>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, InputDataBinding.DeserializeInputDataBinding(property0.Value));
                    }
                    inputDataBindings = dictionary;
                    continue;
                }
                if (property.NameEquals("outputDataBindings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, OutputDataBinding> dictionary = new Dictionary<string, OutputDataBinding>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, OutputDataBinding.DeserializeOutputDataBinding(property0.Value));
                    }
                    outputDataBindings = dictionary;
                    continue;
                }
                if (property.NameEquals("timeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new TrialComponent(codeId.Value, command, distribution.Value, environmentId.Value, Optional.ToDictionary(environmentVariables), Optional.ToDictionary(inputDataBindings), Optional.ToDictionary(outputDataBindings), Optional.ToNullable(timeout));
        }
    }
}
