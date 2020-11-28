using System;
using System.Collections.Generic;
using System.Text;
using LeanringWithMosh.helpers;
using LeanringWithMosh.interfaces;

namespace LeanringWithMosh.Controllers
{
    class CustomerController
    {
        private readonly IDatabase _databaseConnect;

        public CustomerController(IDatabase databaseConnect)
        {
            this._databaseConnect = databaseConnect;
        }

        public static void message()
        {
            Console.WriteLine(sumNumber.Sum2Number(2,2));
            Console.WriteLine("Testing...");
        }

        public IDatabase getRepository()
        {
            return this._databaseConnect;
        }
        
    }
}
