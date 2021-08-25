using Lemure.Delegates;
using System;

namespace Lemure
{
    public class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name is {Name}";
        }
    }
    public class Program
    {
        public static void Change(Person person, string newName)
        {
            person.Name = newName;
            person = new Person(newName);
        }
        public static void Change(out Person person)
        {
            person = new Person("Generic Name");
        }
        public static void Main(string[] args)
        {
            var yuri = new Person("Yuri");
            Person igor;

            Change(out igor);

            Console.WriteLine(igor);

            Console.WriteLine(yuri);
            Change(yuri, "Pedro");
            Console.WriteLine(yuri);
        }
    }
}