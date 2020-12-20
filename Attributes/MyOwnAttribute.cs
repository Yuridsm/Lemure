using System;

namespace LeanringWithMosh.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited= true, AllowMultiple = true)]
    class MyOwnAttribute: Attribute
    {
        private bool myValue;
        public MyOwnAttribute(bool myValues)
        {
            this.myValue = myValues;
        }
    }
}
