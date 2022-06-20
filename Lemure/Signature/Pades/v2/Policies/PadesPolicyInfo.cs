using lemure.Signature.PolicyInformation.OtherHashAlgorithmAndValue;
using lemure.Signature.PolicyInformation.SignPeriod;
using System;

namespace lemure.Signature.Pades.v2.Policies
{
    public class PadesPolicyInfo
    {
        public SigningPeriod SigningPeriod { get; set; }
        public DateTime? RevocationDate { get; set; }
        public string PolicyOID { get;set; }
        public string PolicyURI { get; set; } 
        public OtherHashAlgAndValue PolicyDigest { get; set; }
    }
}
