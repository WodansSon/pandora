using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Kusto.v2022_12_29.Clusters;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum StateConstant
{
    [Description("Creating")]
    Creating,

    [Description("Deleted")]
    Deleted,

    [Description("Deleting")]
    Deleting,

    [Description("Running")]
    Running,

    [Description("Starting")]
    Starting,

    [Description("Stopped")]
    Stopped,

    [Description("Stopping")]
    Stopping,

    [Description("Unavailable")]
    Unavailable,

    [Description("Updating")]
    Updating,
}
