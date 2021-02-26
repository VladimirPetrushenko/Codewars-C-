using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grasshopper___Summation
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int summation(int num)
        {
            //Code here
            return Enumerable.Range(1, num).Sum();
        }
    }
}
