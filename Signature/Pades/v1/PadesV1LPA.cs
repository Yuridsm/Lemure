using LeanringWithMosh.Signature.Pades.v1.Policies;
using System.Collections.Generic;

namespace LeanringWithMosh.Signature.Pades.v1
{
    public class PadesV1LPA
    {
        public IEnumerable<PadesPolicyInfo> PolicyInfos { get; set; }
        public Time NextUpdate { get; set; }
    }
}
