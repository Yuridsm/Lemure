using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.LyingAround
{
    public interface IAgent<T> : ICode
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int age { get; set; }

        public void GetInfo();
    }
}
