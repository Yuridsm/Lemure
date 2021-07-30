using lemure.Signature.Contracts.Pades.V2;
using lemure.Signature.Pades.v2.Policies;
using System;
using System.Collections.Generic;

namespace lemure.Signature.Pades.v2
{
    public class IV2Pades : Contracts.Pades.V2.IV2Pades
    {
        public int Version { get; set; }
        public IEnumerable<PadesPolicyInfo> PolicyInfos { get;set; }
        public DateTime NextUpdate { get; set; }
    }
}
