using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_positive
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int PositiveSum(int[] arr)
        {
            // Your code here
            return arr.Where(x => x > 0).Sum();
        }
    }
}
