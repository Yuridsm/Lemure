using lemure.Signature.Cades.V2.Policies;
using System;
using System.Collections.Generic;

namespace lemure.Signature.Contracts.Cades.V2
{
    public interface IV2Cades
    {
        public int Version { get; set; }
        public IEnumerable<CadesPolicyInfo> PolicyInfos { get; set; }
        public DateTime NextUpdate { get; set; }
    }
}
