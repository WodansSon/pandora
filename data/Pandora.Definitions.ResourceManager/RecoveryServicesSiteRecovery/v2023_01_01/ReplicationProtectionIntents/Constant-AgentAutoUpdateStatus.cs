using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2023_01_01.ReplicationProtectionIntents;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AgentAutoUpdateStatusConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,
}
