using LeanringWithMosh.OOP.AbstractClass;
using LeanringWithMosh.Signature;
using LeanringWithMosh.Signature.Contracts.Cades.V2;
using LeanringWithMosh.Signature.Contracts.Pades.V2;

namespace LeanringWithMosh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var padesURL = "http://politicas.icpbrasil.gov.br/LPA_PAdES.der";
            //var cadesURL = "http://politicas.icpbrasil.gov.br/LPA_CAdES.der";

            //IV2Pades pades = Parse.ParsingV2Pades(padesURL);
            //IV2Cades cades = Parse.ParsingV2Cades(cadesURL);

            TestSO.GetInfo();
        }
    }
}
