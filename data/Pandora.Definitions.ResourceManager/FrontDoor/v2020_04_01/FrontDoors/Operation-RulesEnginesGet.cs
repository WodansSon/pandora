using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.FrontDoor.v2020_04_01.FrontDoors
{
    internal class RulesEnginesGetOperation : Operations.GetOperation
    {
        public override ResourceID? ResourceId() => new RulesEngineId();

        public override Type? ResponseObject() => typeof(RulesEngineModel);


    }
}