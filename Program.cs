using System;
using System.Collections.Generic;
using LeanringWithMosh.Attributes;
using LeanringWithMosh.OOP.Delegates;
using LeanringWithMosh.Collections;

namespace LeanringWithMosh
{

    class Product : IProduct
    {
        public string product { get; set; }
        public int amount { get; set; }
        public double price { get; set; }

        public Product(string product, int amount, double price)
        {
            this.product = product;
            this.amount = amount;
            this.price = price;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*ShowMessageAboutMe Show = new ShowMessageAboutMe();
            Engineer yuri = new Engineer("Yuri", "Melo", 22, "Chemical Engineer at Petrobras");
            Show.ShowDelegate(yuri);*/
            

        }
    }
}
