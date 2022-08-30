// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class DomainData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(InputSchema))
            {
                writer.WritePropertyName("inputSchema");
                writer.WriteStringValue(InputSchema.Value.ToString());
            }
            if (Optional.IsDefined(InputSchemaMapping))
            {
                writer.WritePropertyName("inputSchemaMapping");
                writer.WriteObjectValue(InputSchemaMapping);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(InboundIPRules))
            {
                writer.WritePropertyName("inboundIpRules");
                writer.WriteStartArray();
                foreach (var item in InboundIPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth");
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(AutoCreateTopicWithFirstSubscription))
            {
                writer.WritePropertyName("autoCreateTopicWithFirstSubscription");
                writer.WriteBooleanValue(AutoCreateTopicWithFirstSubscription.Value);
            }
            if (Optional.IsDefined(AutoDeleteTopicWithLastSubscription))
            {
                writer.WritePropertyName("autoDeleteTopicWithLastSubscription");
                writer.WriteBooleanValue(AutoDeleteTopicWithLastSubscription.Value);
            }
            if (Optional.IsDefined(DataResidencyBoundary))
            {
                writer.WritePropertyName("dataResidencyBoundary");
                writer.WriteStringValue(DataResidencyBoundary.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DomainData DeserializeDomainData(JsonElement element)
        {
            Optional<IdentityInfo> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<EventGridPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<DomainProvisioningState> provisioningState = default;
            Optional<string> endpoint = default;
            Optional<InputSchema> inputSchema = default;
            Optional<InputSchemaMapping> inputSchemaMapping = default;
            Optional<string> metricResourceId = default;
            Optional<PublicNetworkAccess> publicNetworkAccess = default;
            Optional<IList<InboundIPRule>> inboundIPRules = default;
            Optional<bool> disableLocalAuth = default;
            Optional<bool> autoCreateTopicWithFirstSubscription = default;
            Optional<bool> autoDeleteTopicWithLastSubscription = default;
            Optional<DataResidencyBoundary> dataResidencyBoundary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = IdentityInfo.DeserializeIdentityInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<EventGridPrivateEndpointConnectionData> array = new List<EventGridPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventGridPrivateEndpointConnectionData.DeserializeEventGridPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new DomainProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpoint"))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inputSchema"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            inputSchema = new InputSchema(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inputSchemaMapping"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            inputSchemaMapping = InputSchemaMapping.DeserializeInputSchemaMapping(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("metricResourceId"))
                        {
                            metricResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inboundIpRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<InboundIPRule> array = new List<InboundIPRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InboundIPRule.DeserializeInboundIPRule(item));
                            }
                            inboundIPRules = array;
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("autoCreateTopicWithFirstSubscription"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoCreateTopicWithFirstSubscription = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("autoDeleteTopicWithLastSubscription"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoDeleteTopicWithLastSubscription = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dataResidencyBoundary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataResidencyBoundary = new DataResidencyBoundary(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DomainData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity.Value, Optional.ToList(privateEndpointConnections), Optional.ToNullable(provisioningState), endpoint.Value, Optional.ToNullable(inputSchema), inputSchemaMapping.Value, metricResourceId.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToList(inboundIPRules), Optional.ToNullable(disableLocalAuth), Optional.ToNullable(autoCreateTopicWithFirstSubscription), Optional.ToNullable(autoDeleteTopicWithLastSubscription), Optional.ToNullable(dataResidencyBoundary));
        }
    }
}
