using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_is_between
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] Between(int a, int b)
        {
            return Enumerable.Range(a, b - a + 1).ToArray();
        }
    }
}
