using LeanringWithMosh.Reflection.NoReflection;
using LeanringWithMosh.Reflection.WithReflection;
using LeanringWithMosh.LazyInitialization;
using Order = LeanringWithMosh.Reflection.NoReflection.Order;
using System.Runtime.InteropServices;
using System;
using LeanringWithMosh.Destructuring;

namespace LeanringWithMosh
{
    public class Program
    {
        public static void LoggerNoReflection(Customer customer, Product product, Order order)
        {
            LogNoReflection.CustomerLog(customer);
            LogNoReflection.ProductLog(product);
            LogNoReflection.OrdersLog(order);
        }

        public static void LoggerWithReflection(Customer customer, Product product, Order order)
        {
            LogWithReflection.Log(customer);
            LogWithReflection.Log(product);
            LogWithReflection.Log(order);
        }

        public static void Main(string[] args)
        {
            // Destructuring tuples
            string myName = "Generic Name";
            string myCity = "Generic City";
            string myState = "Generic State";
            int myHouseNumber = 0;

            DestructuringTuples.GetData();
            (string name, string city, string state, int houseNumber) = DestructuringTuples.GetAddressInfo();
            (myName, myCity, myState, myHouseNumber) = DestructuringTuples.GetAddressInfo();
            Console.WriteLine(name);
            Console.WriteLine(city);
            Console.WriteLine(state);
            Console.WriteLine(myHouseNumber);
        }

        

    }
}
