using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.PowerBIDedicated.v2021_01_01.AutoScaleVCores
{
    [ConstantType(ConstantTypeAttribute.ConstantType.String)]
    internal enum IdentityTypeConstant
    {
        [Description("Application")]
        Application,

        [Description("Key")]
        Key,

        [Description("ManagedIdentity")]
        ManagedIdentity,

        [Description("User")]
        User,
    }
}