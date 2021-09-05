using System;
using System.Diagnostics;
using lemure.Collections.Domain;
using System.Collections.Generic;
using lemure.Collections.Enumerations;

namespace Lemure
{
    public class Program
    {
        public static List<Product> GenerateProducts(int amount)
        {
            var products = new List<Product>();

            for(int i = 0; i < amount; i++)
            {
                products.Add(new Product("gdfgdfdg", "dgdfg", "gfgdfg"));
            }

            return products;
        }

        public static string[] GetNames(List<Product> products)
        {
            var result = new string[products.Count];

            for (int i = 0; i < products.Count; i++)
            {
                result[i] = products[i]._name;
            }

            return result;
        }

        public static IEnumerable<Product> GetProducts(List<Product> products)
            => new MyInfinityEnumerable(products);

        public static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            // Generate the data fror simulation
            // Get all product from database
            var products = GenerateProducts(100000);

            // Get the name of all them
            var names = GetNames(products);

            foreach(var name in names)
            {
                Console.WriteLine($"Time: {sw.ElapsedMilliseconds / 1000.0} seg");
            }
        }
    }
}
