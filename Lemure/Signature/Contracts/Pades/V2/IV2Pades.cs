using lemure.Signature.Pades.v2.Policies;
using System;
using System.Collections.Generic;

namespace lemure.Signature.Contracts.Pades.V2
{
    public interface IV2Pades
    {
        public int Version { get; set; }
        public IEnumerable<PadesPolicyInfo> PolicyInfos { get; set; }
        public DateTime NextUpdate { get; set; }
    }
}
