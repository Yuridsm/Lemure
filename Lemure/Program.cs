using Lemure.Delegates;

namespace Lemure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var yuri = new Person("Yuri Melo", 23);
            ExampleDelegate.GetInformation(yuri, yuri.OneMoreAge, yuri.RiseSalary);
        }
    }
}
