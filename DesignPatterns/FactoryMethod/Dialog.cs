using Lemure.DesignPatterns.FactoryMethod.Contracts;
using System;

namespace Lemure.DesignPatterns.FactoryMethod
{
    public abstract class Dialog
    {
        public abstract Button CreateButton();

        public void Render()
        {
            var button = CreateButton();
            button.Render();
        }
    }
}
