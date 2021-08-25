using System;

namespace Lemure.Delegates
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        int OneMoreAge();
    }

    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int OneMoreAge()
        {
            return Age+1;
        }
    }

    public class ExampleDelegate
    {
        public delegate int Transform ();
        public static void GetInformation(IPerson person, Transform t)
        {
            Console.WriteLine($"My new age is {t.Invoke()}");
        }
    }
}