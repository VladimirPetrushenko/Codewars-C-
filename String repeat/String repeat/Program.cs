using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_repeat
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string repeatStr(int n, string s)
        {
            return string.Join(string.Empty,Enumerable.Repeat(s,n));
        }
    }
}
