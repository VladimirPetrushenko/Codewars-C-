using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_n_divisible_by_x_and_y
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool isDivisible(long n, long x, long y)
        {
            // your code
            return n % x == 0 && n % y == 0;
        }
    }
}
