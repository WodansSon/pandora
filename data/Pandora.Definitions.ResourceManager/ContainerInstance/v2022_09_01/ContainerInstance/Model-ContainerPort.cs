using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerInstance.v2022_09_01.ContainerInstance;


internal class ContainerPortModel
{
    [JsonPropertyName("port")]
    [Required]
    public int Port { get; set; }

    [JsonPropertyName("protocol")]
    public ContainerNetworkProtocolConstant? Protocol { get; set; }
}