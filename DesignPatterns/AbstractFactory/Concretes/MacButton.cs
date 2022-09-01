using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lemure.DesignPatterns.AbstractFactory.Contracts;

namespace Lemure.DesignPatterns.AbstractFactory.Concretes
{
    public class MacButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("MAC Button");
        }
    }
}
