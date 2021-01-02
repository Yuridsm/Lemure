using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.interfaces.Attribute
{
    public interface IContractAttribute
    {
        public string firstName { get; }
        public string lastName { get; }
        public string age { get; }
        public bool assign { get; }
    }
}
