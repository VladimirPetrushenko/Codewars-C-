using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nextPerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextPerfectSquare(0));
            Console.ReadLine();
        }
        public static long NextPerfectSquare(long n)
        {
            // write your function and return the next perfect square
            return n < 0 ? 0 : Convert.ToInt64(Math.Pow(Math.Floor(Math.Sqrt(n)) + 1, 2));
        }
    }
}
