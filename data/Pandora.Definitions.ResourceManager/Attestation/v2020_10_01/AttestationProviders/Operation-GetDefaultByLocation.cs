using Pandora.Definitions.Attributes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.Attestation.v2020_10_01.AttestationProviders
{
    internal class GetDefaultByLocationOperation : Operations.GetOperation
    {
        public override ResourceID? ResourceId()
        {
            return new LocationId();
        }

        public override Type? ResponseObject()
        {
            return typeof(AttestationProviderModel);
        }

        public override string? UriSuffix()
        {
            return "/defaultProvider";
        }


    }
}