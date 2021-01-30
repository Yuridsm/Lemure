using LeanringWithMosh.Collections.Enumerations;
using LeanringWithMosh.Collections;
using LeanringWithMosh.OOP.Delegates;
using System;
using static LeanringWithMosh.OOP.Delegates.SampleDelegate;
using System.Collections.Generic;
using System.Linq;

namespace LeanringWithMosh
{
    public class Program
    {
        private delegate String myDelegateForMusic1(string music);
        private delegate String myDelegateForMusic2();
        public static void Main(string[] args)
        {
            mySampleClass smp = new mySampleClass();
            myMethodDelegate myD1 = new myMethodDelegate(smp.myStringMethod);
            myMethodDelegate myD2 = new myMethodDelegate(mySampleClass.mySignMethod);

            /*Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 5, myD1(5), myD2(5));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", -3, myD1(-3), myD2(-3));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 0, myD1(0), myD2(0));*/

            PlayFavoriteMusic music = new PlayFavoriteMusic();
            myDelegateForMusic1 music1 = new myDelegateForMusic1(music.play);
            myDelegateForMusic2 music2 = new myDelegateForMusic2(PlayFavoriteMusic.next);

            Console.WriteLine("Which music is playing?");
            Console.WriteLine(music1("ela vem"));
            Console.WriteLine("Next music is :");
            Console.WriteLine(music2());
            Console.WriteLine(music1.GetInvocationList());
            Console.WriteLine(FuncDelegate.selector("YURI MELOOOO"));
            // ---
            Func<string, string> selector = str => str.ToUpper();
            string[] name = { "yuri melo", "developer", "23 years old" };
            IEnumerable<String> words = name.Select(selector);
            foreach (String a in words)
                Console.WriteLine(a);
        }
    }
}
