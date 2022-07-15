using Lemure.DesignPatterns.FactoryMethod.Contracts;
using System;

namespace Lemure.DesignPatterns.FactoryMethod.Concretes
{
    public class LinuxButton : Button
    {
        public void Render()
        {
            Console.WriteLine("Rendering the Linux Button");
        }
    }
}
