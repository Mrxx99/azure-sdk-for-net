// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class NodeStateCounts
    {
        internal static NodeStateCounts DeserializeNodeStateCounts(JsonElement element)
        {
            Optional<int> idleNodeCount = default;
            Optional<int> runningNodeCount = default;
            Optional<int> preparingNodeCount = default;
            Optional<int> unusableNodeCount = default;
            Optional<int> leavingNodeCount = default;
            Optional<int> preemptedNodeCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("idleNodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    idleNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("runningNodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    runningNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preparingNodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preparingNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unusableNodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unusableNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("leavingNodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    leavingNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preemptedNodeCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preemptedNodeCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new NodeStateCounts(Optional.ToNullable(idleNodeCount), Optional.ToNullable(runningNodeCount), Optional.ToNullable(preparingNodeCount), Optional.ToNullable(unusableNodeCount), Optional.ToNullable(leavingNodeCount), Optional.ToNullable(preemptedNodeCount));
        }
    }
}
