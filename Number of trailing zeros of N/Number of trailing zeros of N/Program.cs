using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_trailing_zeros_of_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TrailingZeros(5));
            Console.ReadLine();
        }
        public static int TrailingZeros(int n)
        {
            int a = 0;
            a = n / 5;
            if (a >= 5)
            {
                a += TrailingZeros(a);
            }
            return a;
        }
    }
}
