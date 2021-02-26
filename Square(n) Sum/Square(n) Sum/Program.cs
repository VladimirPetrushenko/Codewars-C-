using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_n__Sum
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int SquareSum(int[] n)
        {
            return n.Select(x => x * x).Sum();
        }
    }
}
