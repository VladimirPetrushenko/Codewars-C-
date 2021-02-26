using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_divisible_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static long DivisibleCount(long x, long y, long k)
        {
            return Enumerable.Range((int)x, (int)(y - x) + 1).ToArray().Where(m => m % k == 0).Count();
        }
    }
}
