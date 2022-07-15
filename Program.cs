using Lemure.DesignPatterns.FactoryMethod;
using Lemure.Enums;

namespace Lemure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryMethodApp factoryMethodApp = new FactoryMethodApp(OpeSys.Linux);
            factoryMethodApp.Run();
        }
    }
}
