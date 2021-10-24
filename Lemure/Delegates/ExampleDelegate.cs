using System;

namespace Lemure.Delegates
{
    public interface IPerson
    {
        string Name { get; }
        int Age { get; }
        double Salary { get; }
        int OneMoreAge();
        double RiseSalary(double salary);
    }

    public class Person : IPerson
    {
        private readonly string _name;
        private int _age;
        private double _salary;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
            _salary = 1000.00;
        }

        public string Name
        {
            get {
                return _name;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
        }
        public double Salary
        {
            get
            {
                return _salary;
            }
        }
        public int OneMoreAge() => _age + 1;

        public double RiseSalary(double salary)
        {
            _salary += salary;
            return _salary;
        }
    }

    public class ExampleDelegate
    {
        public delegate int Transform ();
        public delegate double RiseSalary(double salary);
        public static void GetInformation(IPerson person, Transform t, RiseSalary riseSalary)
        {
            Console.WriteLine($"My new age is {t.Invoke()}");
            Console.WriteLine($"My current salary is: {person.Salary}");
            Console.WriteLine($"My new age is {riseSalary.Invoke(10.00)}");
            Console.WriteLine($"My current salary is: {person.Salary}");
        }
    }
}