using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DesktopVirtualization.v2022_09_09.Workspace;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum SkuTierConstant
{
    [Description("Basic")]
    Basic,

    [Description("Free")]
    Free,

    [Description("Premium")]
    Premium,

    [Description("Standard")]
    Standard,
}