using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.LabServices.v2022_08_01.Lab;


internal class LabUpdateModel
{
    [JsonPropertyName("properties")]
    public LabUpdatePropertiesModel? Properties { get; set; }

    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }
}