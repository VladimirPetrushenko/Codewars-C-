using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Monkeys
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] MonkeyCount(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }
    }
}
