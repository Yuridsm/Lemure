using LeanringWithMosh.Signature.PolicyInformation.OtherHashAlgorithmAndValue;

namespace LeanringWithMosh.Signature.Pades.v1.Policies
{
    public class PoliciesDigest
    {
        public OtherHashAlgAndValue TextualPolicyDigest { get; set; }
        public OtherHashAlgAndValue ANS1PolicyDigest { get; set; }
        public OtherHashAlgAndValue XMLPolicyDigest { get; set; }
    }
}
