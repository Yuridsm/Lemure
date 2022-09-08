using Lemure.DesignPatterns.FactoryMethod.Concretes;
using Lemure.DesignPatterns.FactoryMethod.Contracts;
using System;

namespace Lemure.DesignPatterns.FactoryMethod.Creators
{
    public class WindowsDialogFactory : Dialog
    {
        public override Button FactoryMethod()
        {
            Console.WriteLine("Create Button for Windows...");
            return new WindowsButton();
        }
    }
}
