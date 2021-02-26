using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Can_we_divide_it
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool is_divide_by(int number, int a, int b)
        {
            // good luck
            return number % Math.Abs(a) == 0 && number % Math.Abs(b) == 0;
        }
    }
}
