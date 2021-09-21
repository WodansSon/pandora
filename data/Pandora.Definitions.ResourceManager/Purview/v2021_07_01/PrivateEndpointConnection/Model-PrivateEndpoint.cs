using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.Purview.v2021_07_01.PrivateEndpointConnection
{

    internal class PrivateEndpointModel
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}