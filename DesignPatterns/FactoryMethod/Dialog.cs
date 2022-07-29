using Lemure.DesignPatterns.FactoryMethod.Contracts;

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
