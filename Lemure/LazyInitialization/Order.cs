using System;
using System.Collections.Generic;
using System.Text;

namespace lemure.LazyInitialization
{
    public class Order
    {
        public string _name { get; set; }
        public int _price { get; set; }
        public string _owner { get; set; }
        private List<Order> _orders { get; set; }

        public Order(string name, int price, string owner)
        {
            _name = name;
            _price = price;
            _owner = owner;
        }
        public Order()
        {
        }

        public List<Order> create(int amount)
        {
            if(amount != 0 && amount != 1)
            {
                amount = amount - 1;
            }
            _orders = new List<Order>();
            for (int i=0; i< amount; i++)
            {
                _orders.Add(new Order("", 1, ""));
            }
            return _orders;
        }

        public override string ToString()
        {
            return "Name: " + _name + "\nPrice: " + _price + "\nOwne: r" + _owner;
        }
    }
}
