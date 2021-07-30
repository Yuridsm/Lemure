using lemure.Signature.PolicyInformation.OtherHashAlgorithmAndValue;

namespace lemure.Signature.Pades.v1.Policies
{
    public class PoliciesDigest
    {
        public OtherHashAlgAndValue TextualPolicyDigest { get; set; }
        public OtherHashAlgAndValue ANS1PolicyDigest { get; set; }
        public OtherHashAlgAndValue XMLPolicyDigest { get; set; }
    }
}
