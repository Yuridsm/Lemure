using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.Struct
{
    public struct TaggedInteger
    {
        public int Number;
        private List<string> tags;

        public TaggedInteger(int n)
        {
            Number = n;
            tags = new List<string>();
        }

        public void AddTag(string tag) => tags.Add(tag);
        public override string ToString() => $"{Number} [{string.Join(", ", tags)}]";
    }
}
