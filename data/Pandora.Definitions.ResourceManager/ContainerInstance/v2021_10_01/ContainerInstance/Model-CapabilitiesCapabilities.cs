using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerInstance.v2021_10_01.ContainerInstance;


internal class CapabilitiesCapabilitiesModel
{
    [JsonPropertyName("maxCpu")]
    public float? MaxCPU { get; set; }

    [JsonPropertyName("maxGpuCount")]
    public float? MaxGpuCount { get; set; }

    [JsonPropertyName("maxMemoryInGB")]
    public float? MaxMemoryInGB { get; set; }
}
