using System;
using LeanringWithMosh.Attributes;
using LeanringWithMosh.interfaces.Attribute;

namespace LeanringWithMosh.Attributes
{
    public class Contract : IContractAttribute
    {
        public string firstName { get; }
        public string lastName { get; }
        public string age { get; }
        public bool assign { get; }
        public Contract(string firstName, string lastName, string age, bool assign)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.assign = assign;
        }
    }

    public class UsingAttributes
    {
        private IContractAttribute myOwnContract { get; set; }
        public UsingAttributes()
        {
            //Contract myOwnContract = 
            myOwnContract = new Contract("", "", "", true);
        }

        [MyOwn(true, description: "Yuri")]
        public static void TestingAttribute()
        {
            //Console.WriteLine(MyOwnAttribute);
        }
    }
}
