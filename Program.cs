using System;
using LeanringWithMosh.DropCode;

namespace LeanringWithMosh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var foo = Foo.Boo();

            foreach(var elem in foo)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
