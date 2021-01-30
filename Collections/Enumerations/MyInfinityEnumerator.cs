using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.Collections.Enumerations
{
    public class MyInfinityEnumerator : IEnumerator<Product>
    {
        public Product[] _products { get; set; }
        private int index = -1;

        public MyInfinityEnumerator(Product[] products)
        {
            _products = products;
        }

        public Product Current {
            get => _products[index];
        }
        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index++;
            return index < _products.Length;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
