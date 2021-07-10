// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class EarlyTerminationPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DelayEvaluation))
            {
                writer.WritePropertyName("delayEvaluation");
                writer.WriteNumberValue(DelayEvaluation.Value);
            }
            if (Optional.IsDefined(EvaluationInterval))
            {
                writer.WritePropertyName("evaluationInterval");
                writer.WriteNumberValue(EvaluationInterval.Value);
            }
            writer.WritePropertyName("policyType");
            writer.WriteStringValue(PolicyType.ToString());
            writer.WriteEndObject();
        }

        internal static EarlyTerminationPolicy DeserializeEarlyTerminationPolicy(JsonElement element)
        {
            if (element.TryGetProperty("policyType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Bandit": return BanditPolicy.DeserializeBanditPolicy(element);
                    case "MedianStopping": return MedianStoppingPolicy.DeserializeMedianStoppingPolicy(element);
                    case "TruncationSelection": return TruncationSelectionPolicy.DeserializeTruncationSelectionPolicy(element);
                }
            }
            Optional<int> delayEvaluation = default;
            Optional<int> evaluationInterval = default;
            EarlyTerminationPolicyType policyType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delayEvaluation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    delayEvaluation = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("evaluationInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    evaluationInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyType"))
                {
                    policyType = new EarlyTerminationPolicyType(property.Value.GetString());
                    continue;
                }
            }
            return new EarlyTerminationPolicy(Optional.ToNullable(delayEvaluation), Optional.ToNullable(evaluationInterval), policyType);
        }
    }
}
