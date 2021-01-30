using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.OOP.Delegates
{
    public class SampleDelegate
    {
        public delegate String myMethodDelegate(int myInt);

        public class mySampleClass
        {
            public String myStringMethod(int myInt)
            {
                if(myInt > 0)
                    return ("positive");
                if(myInt < 0)
                    return ("negative");
                return ("zero");
            }

            public static String mySignMethod(int myInt)
            {
                if (myInt > 0)
                    return ("+");
                if(myInt > 0)
                    return ("+");
                return ("");
            }
        }
    }
}
