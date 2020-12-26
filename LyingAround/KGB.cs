using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeanringWithMosh.LyingAround
{
    public class KGB
    {
        public string agent;
        public int age;
        public string department;
        public string code;

        public string KGBAgentCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            code = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return code;
        }
    }
}
