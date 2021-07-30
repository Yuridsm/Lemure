using lemure.LazyInitialization;
using System.Collections.Generic;

namespace Lemure.LazyInitialization
{
    public class Orders
    {
        private List<Order> _orders;
        public Orders()
        {
        }
        public List<Order> create(int amount)
        {
            if (amount != 0 && amount != 1)
            {
                amount = amount - 1;
            }
            _orders = new List<Order>();
            for (int i = 0; i < amount; i++)
            {
                _orders.Add(new Order("", 1, ""));
            }
            return _orders;
        }
    }
}
