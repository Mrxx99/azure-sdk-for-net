// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class TopologyList
    {
        internal static TopologyList DeserializeTopologyList(JsonElement element)
        {
            Optional<IReadOnlyList<TopologyResourceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TopologyResourceData> array = new List<TopologyResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopologyResourceData.DeserializeTopologyResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TopologyList(Optional.ToList(value), nextLink.Value);
        }
    }
}
