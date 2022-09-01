using System;
using System.Collections.Generic;
namespace Lemure.DesignPatterns.Adapter.Concretes
{
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}
