using System;
using System.Collections.Generic;
using System.Linq;

namespace LeanringWithMosh
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /*Person[] peopleArray = new Person[3] 
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon")
            };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);*/
            var names = new List<string> { "sam", "alexia", "simon", "sumanth", "tony", "sam", "amr", "mark", "drew" };
            var moreThenFiveLetters = names.Where(w => w.Length > 5);
            names[0] = "benjamin";

            foreach(var name in moreThenFiveLetters)
            {
                Console.WriteLine(name);
            }

        }
    }
}
