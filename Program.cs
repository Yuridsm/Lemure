using System;
using lemure.DropCode;

namespace lemure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Lambda.GetDelegate(2));
        }
    }
}