using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2017_04_01.CheckNameAvailabilityNamespaces
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "70626b932d16a97361673e0bcba7570284fe0813" 

        public string ApiVersion => "2017-04-01";
        public string Name => "CheckNameAvailabilityNamespaces";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new NamespacesCheckNameAvailabilityOperation(),
        };
    }
}