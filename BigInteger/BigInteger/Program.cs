using System;
using System.Numerics;

namespace BigIntegerFCN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fcn(17));
            Console.ReadLine();
        }
        public static long fcn(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 2;
            }
            return 6 * fcn(n - 2) * fcn(n - 1) / (5 * fcn(n - 2) -  fcn(n - 1));
        }
    }
}
