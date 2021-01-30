using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeanringWithMosh.LyingAround
{
    public class KGB : IAgent<KGB>
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int age { get; set; }
        public int code { get; set; }

        public void GetInfo()
        {
            Console.WriteLine(fName);
            Console.WriteLine(lName);
            Console.WriteLine(age);
        }
    }
}
