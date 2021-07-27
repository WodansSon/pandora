using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.VMware.v2020_03_20.Clusters
{

    internal class ClusterUpdate
    {
        [JsonPropertyName("properties")]
        public ClusterUpdateProperties? Properties { get; set; }
    }
}