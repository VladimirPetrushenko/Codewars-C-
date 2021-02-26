using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Long_Short
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string Solution(string a, string b)
        {
            return a.Length > b.Length ? b + a + b : a + b + a;
        }
    }
}
