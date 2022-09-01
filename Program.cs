using Lemure.DesignPatterns.AbstractFactory;
using Lemure.Enums;

namespace Lemure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            App application = new App();
            application.Run(OpeSys.Windows);
        }
    }
}
