using LeanringWithMosh.Enums;
using System;
using LeanringWithMosh.Struct;

namespace LeanringWithMosh
{
    public class Program
    {
        private delegate String myDelegateForMusic1(string music);
        private delegate String myDelegateForMusic2();

        private static void MutateAndDisplay(MutablePoint p)
        {
            p.X = 100;
            Console.WriteLine($"Point mutated in a method: {p}");
        }

        public static void Main(string[] args)
        {
            MyOptions g1 = MyOptions.D; // 1
            MyOptions g2 = MyOptions.F; // 0
            MyOptions g3 = MyOptions.A; // 4

            Console.WriteLine("First {0} a passing grade.", g1.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade.", g2.Passing() ? "is" : "is not");

            EnumExtension.minPassing = MyOptions.C; // 2
            Console.WriteLine("\r\nRaising the bar!\r\n");
            Console.WriteLine("First {0} a passing grade.", g1.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade.", g2.Passing() ? "is" : "is not");
            Console.WriteLine("Second {0} a passing grade.", g3.Passing() ? "is" : "is not");
        }
    }
}
