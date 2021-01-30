using System.Collections;
using System.Collections.Generic;
using LeanringWithMosh.Collections;

namespace LeanringWithMosh.Collections.Enumerations
{
    public class MyInfinityEnumerable : IEnumerable<Product>
    {
        private readonly Product[] _products;
        public MyInfinityEnumerable(Product[] products)
        {
            _products = products;
        }
        public IEnumerator<Product> GetEnumerator()
        {
            return new MyInfinityEnumerator(_products);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyInfinityEnumerator(_products);
        }
    }
}
