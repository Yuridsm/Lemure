using System;
using lemure.DropCode;

namespace lemure
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
