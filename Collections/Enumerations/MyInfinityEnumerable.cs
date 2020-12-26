using System.Collections;
using System.Collections.Generic;

namespace LeanringWithMosh.Collections.Enumerations
{
    public class MyInfinityEnumerable : IEnumerable<int>
    {
        public IEnumerator GetEnumerator()
        {
            return new MyInfinityEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new MyInfinityEnumerator();
        }
    }

    public class MyInfinityEnumerator : IEnumerator<int>
    {
        public object Current { get; private set; } = 0;

        int IEnumerator<int>.Current => throw new System.NotImplementedException();

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }

}
