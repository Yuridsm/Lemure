using Lemure.DesignPatterns.FactoryMethod.Contracts;
using System;

namespace Lemure.DesignPatterns.FactoryMethod.Concretes
{
    public class MacButton : Button
    {
        public void Render()
        {
            Console.WriteLine("Rendering the Mac OS Button");
        }
    }
}
