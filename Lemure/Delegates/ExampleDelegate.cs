using System;
using System.Collections.Generic;

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
        public string[] books = { "               Book 1", "Book 2           ", "Book 3" };
        public delegate int Transform ();
        public delegate double RiseSalary(double salary);
        public delegate string TransformStringInto(string bookTitle);
        public static void GetInformation(IPerson person, Transform t, RiseSalary riseSalary)
        {
            Console.WriteLine($"My new age is {t.Invoke()}");
            Console.WriteLine($"My current salary is: {person.Salary}");
            Console.WriteLine($"My new age is {riseSalary.Invoke(10.00)}");
            Console.WriteLine($"My current salary is: {person.Salary}");
        }

        public void TransformInto(string[] books, TransformStringInto t)
        {
            for(int index = 0; index < books.Length; index++)
            {
                books[index] = t.Invoke(books[index]);
                Console.WriteLine(books[index]);
            }
        }

        #region UtilMethods
        public string TransformIntoUpcase(string str) => str.ToUpper();
        public string TransformIntoLowerCase(string str) => str.ToLower();
        public string ApplyTrim(string str) => str.Trim();
        #endregion
    }
}