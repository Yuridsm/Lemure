using LeanringWithMosh.Signature.PolicyInformation.OtherHashAlgorithmAndValue;
using LeanringWithMosh.Signature.PolicyInformation.SignPeriod;
using System;

namespace LeanringWithMosh.Signature.Cades.V2.Policies
{
    public class CadesPolicyInfo
    {
        public SigningPeriod SigningPeriod { get; set; }
        public DateTime? RevocationDate { get; set; }
        public string PolicyOID { get;set; }
        public string PolicyURI { get; set; } 
        public OtherHashAlgAndValue PolicyDigest { get; set; }
    }
}
