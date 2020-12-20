using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.Attributes
{
    class UsingAttributes
    {
        [Obsolete("Will be removed in next version")]
        public static int Add(int a, int b)
        {
            return (a + b);
        }
    }
}
