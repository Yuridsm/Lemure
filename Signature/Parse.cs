using lemure.Signature.PolicyInformation.SignPeriod;
using lemure.Signature.PolicyInformation.OtherHashAlgorithmAndValue;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using lemure.Signature.Pades.v2;
using lemure.Signature.Pades.v2.Policies;
using lemure.Signature.Cades.V2.Policies;
using lemure.Signature.Contracts.Cades.V2;
using lemure.Signature.Cades.V2;

namespace lemure.Signature
{
    public class Parse
    {
        public static IV2Cades ParsingV2Cades(string url)
        {
            var response = new WebClient().DownloadData(url);
            var policy = new CadesPolicyInfo();
            var policyInfoSequences = new List<CadesPolicyInfo>();

            #region LPA
            IV2Cades lpa = new CadesV2LPA();

            var cadesLPA = (DerSequence) DerSequence.FromByteArray(response);
            var fixIndex = 0;
            var version = 2;

            #region Version
            if (cadesLPA.Count == 3)
            {
                var derIntegerVersion = (DerInteger) cadesLPA[0];
                version = derIntegerVersion.IntValueExact;

                lpa.Version = version;

                fixIndex++;
            }
            else
            {
                lpa.Version = version;
            }
            #endregion

            #region PolicyInfos
            var policyInfos = (DerSequence) cadesLPA[0+fixIndex];

            foreach (var policyInfo in policyInfos)
            {
                /*
                 * It's useful for indexing the arrays positions on 'sequences' in better way
                 */
                var parameterIndex = 0;
                var sequences = (DerSequence) policyInfo;

                #region RevocationDate
                if (sequences.Count == 5)
                {
                    var revocationDate = (DerGeneralizedTime) sequences[1];
                    policy.RevocationDate = Parse.FormatDate(revocationDate.TimeString);

                    
                    parameterIndex++;
                }
                #endregion

                #region SigningPeriod
                //...lots of code...
                var signingPeriod = (DerSequence) sequences[0];

                var notAfter = (DerGeneralizedTime) signingPeriod[0];
                var notBefore = (DerGeneralizedTime) signingPeriod[1];
                #endregion

                #region PolicyOID
                /* PolicyOID */
                var objectIdentifier = (DerObjectIdentifier) sequences[1+parameterIndex];
                var policyOID = objectIdentifier.Id;
                #endregion

                #region PolicyURI
                var policyURI = (DerIA5String) sequences[2+parameterIndex];
                #endregion

                #region PolicyDigest
                var policyDigest = (DerSequence) sequences[3+parameterIndex];
                var OtherHashAlgAndValue = (DerSequence) policyDigest[0];

                var hashAlgorithm = (DerObjectIdentifier) OtherHashAlgAndValue[0];
                var hashValue = (DerOctetString) policyDigest[1];
                #endregion

                #region PolicyInfo
                policy.SigningPeriod = new SigningPeriod
                {
                    NotAfter = Parse.FormatDate(notAfter.TimeString),
                    NotBefore = Parse.FormatDate(notBefore.TimeString)
                };

                policy.PolicyOID = policyOID;
                policy.PolicyURI = policyURI.GetString();
                policy.PolicyDigest = new OtherHashAlgAndValue
                {
                    HashAlgorithm = hashAlgorithm.Id,
                    HashValue = hashValue.ToString()
                };
                #endregion

                policyInfoSequences.Add(policy);
            }
            
            lpa.PolicyInfos = policyInfoSequences;
            #endregion

            #region NextUpdate
            var nextUpdate = (DerGeneralizedTime)cadesLPA[1+fixIndex];
            lpa.NextUpdate = Parse.FormatDate(nextUpdate.TimeString);
            #endregion

            return lpa;
            #endregion
        }
        /*public static void ParsingV1Pades(string url)
        {
            var response = new WebClient().DownloadData(url);
            var padesLPA = (DerSequence) DerSequence.FromByteArray(response);

            var policyInfoSequences = new List<Pades.v1.Policies.PadesPolicyInfo>();

            #region LPA
            PadesV1LPA lpa = new PadesV1LPA();

            #region PolicyInfos
            var policyInfos = (DerSequence) padesLPA[0];
            foreach (var policy in policyInfos)
            {
                // Do assignments to policyInfo object
            }

            #endregion

            #region NextUpdate
            var nextUpdate = (DerGeneralizedTime) padesLPA[1];
            lpa.NextUpdate.GeneralizedTime = Parse.FormatDate(nextUpdate.TimeString);
            #endregion

            #endregion
        }*/
        public static IV2Pades ParsingV2Pades(string url)
        {
            var response = new WebClient().DownloadData(url);
            var policy = new PadesPolicyInfo();
            var policyInfoSequences = new List<PadesPolicyInfo>();

            #region LPA
            IV2Pades lpa = new IV2Pades();

            var padesLPA = (DerSequence) DerSequence.FromByteArray(response);
            var fixIndex = 0;
            var version = 2;

            #region Version
            if (padesLPA.Count == 3)
            {
                var derIntegerVersion = (DerInteger)padesLPA[0];
                version = derIntegerVersion.IntValueExact;

                lpa.Version = version;

                fixIndex++;
            }
            else
            {
                lpa.Version = version;
            }
            #endregion

            #region PolicyInfos
            var policyInfos = (DerSequence)padesLPA[0 + fixIndex];

            foreach (var policyInfo in policyInfos)
            {
                /*
                 * It's useful for indexing the arrays positions on 'sequences' in better way
                 */
                var parameterIndex = 0;
                var sequences = (DerSequence)policyInfo;

                #region RevocationDate
                if (sequences.Count == 5)
                {
                    var revocationDate = (DerGeneralizedTime)sequences[1];
                    policy.RevocationDate = Parse.FormatDate(revocationDate.TimeString);


                    parameterIndex++;
                }
                #endregion

                #region SigningPeriod
                //...lots of code...
                var signingPeriod = (DerSequence)sequences[0];

                var notAfter = (DerGeneralizedTime)signingPeriod[0];
                var notBefore = (DerGeneralizedTime)signingPeriod[1];
                #endregion

                #region PolicyOID
                /* PolicyOID */
                var objectIdentifier = (DerObjectIdentifier)sequences[1 + parameterIndex];
                var policyOID = objectIdentifier.Id;
                #endregion

                #region PolicyURI
                var policyURI = (DerIA5String)sequences[2 + parameterIndex];
                #endregion

                #region PolicyDigest
                var policyDigest = (DerSequence)sequences[3 + parameterIndex];
                var OtherHashAlgAndValue = (DerSequence)policyDigest[0];

                var hashAlgorithm = (DerObjectIdentifier)OtherHashAlgAndValue[0];
                var hashValue = (DerOctetString)policyDigest[1];
                #endregion

                #region PolicyInfo
                policy.SigningPeriod = new SigningPeriod
                {
                    NotAfter = Parse.FormatDate(notAfter.TimeString),
                    NotBefore = Parse.FormatDate(notBefore.TimeString)
                };

                policy.PolicyOID = policyOID;
                policy.PolicyURI = policyURI.GetString();
                policy.PolicyDigest = new OtherHashAlgAndValue
                {
                    HashAlgorithm = hashAlgorithm.Id,
                    HashValue = hashValue.ToString()
                };
                #endregion

                policyInfoSequences.Add(policy);
            }

            lpa.PolicyInfos = policyInfoSequences;
            #endregion

            #region NextUpdate
            var nextUpdate = (DerGeneralizedTime)padesLPA[1 + fixIndex];
            lpa.NextUpdate = Parse.FormatDate(nextUpdate.TimeString);
            #endregion

            return lpa;
            #endregion
        }
        public static DerSequence InitPadesLPA(string url)
        {
            var response = new WebClient().DownloadData(url);
            var padesLPA = (DerSequence) DerSequence.FromByteArray(response);
            return padesLPA;
        }

        #region StaticMethods
        static DateTime FormatDate(string inputDate)
        {
            DateTime date = DateTime.ParseExact(inputDate, "yyyyMMddHHmmssZ", CultureInfo.InvariantCulture);
            return date;
        }
        #endregion
    }
}
