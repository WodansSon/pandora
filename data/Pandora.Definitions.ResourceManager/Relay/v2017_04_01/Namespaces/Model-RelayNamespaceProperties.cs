using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.Relay.v2017_04_01.Namespaces
{

    internal class RelayNamespaceProperties
    {
        [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("metricId")]
        public string? MetricId { get; set; }

        [JsonPropertyName("provisioningState")]
        public ProvisioningStateEnum? ProvisioningState { get; set; }

        [JsonPropertyName("serviceBusEndpoint")]
        public string? ServiceBusEndpoint { get; set; }

        [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
    }
}