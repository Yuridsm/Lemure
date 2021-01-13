using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.Destructuring
{
    public class DestructuringTuples
    {
        private static (string, int, double) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.77);
            return ("", 0, 0);
        }

        public static (string, string, string, int) GetAddressInfo()
        {
            return (
                "Yuri Melo",
                "Batalha",
                "Alagoas",
                180
            );
        }

        public static void GetData()
        {
            var result = QueryCityData("New York City");
            var city = result.Item1;
            var pop = result.Item2;
            var size = result.Item3;
            Console.WriteLine(city);
            Console.WriteLine(pop);
            Console.WriteLine(size);
        }
    }
}
