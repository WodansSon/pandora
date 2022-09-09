using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataProtection.v2022_05_01.BackupInstances;


internal abstract class RestoreTargetInfoBaseModel
{
    [JsonPropertyName("objectType")]
    [ProvidesTypeHint]
    [Required]
    public string ObjectType { get; set; }

    [JsonPropertyName("recoveryOption")]
    [Required]
    public RecoveryOptionConstant RecoveryOption { get; set; }

    [JsonPropertyName("restoreLocation")]
    public string? RestoreLocation { get; set; }
}