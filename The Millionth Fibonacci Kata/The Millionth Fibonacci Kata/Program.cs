using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace The_Millionth_Fibonacci_Kata
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib(2000000));
            Console.ReadLine();
        }
        public static BigInteger fib(int n)
        {
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger priviousB;
            BigInteger Fn = 0;
            BigInteger d = 1;
            BigInteger Fn1 = 1;
            int m = Math.Abs(n);
            while (m != 0)
            {
                //power is odd
                if ((m % 2) != 0)
                {
                    priviousB = Fn * b;
                    Fn = Fn * a + Fn1 * b;
                    Fn1 = priviousB + Fn1 * d;
                }

                priviousB = b * b;
                b = a * b + b * d;
                a = a * a + priviousB;
                d = priviousB + d * d;

                m >>= 1;
            }
            if ((n < 0) & (n % 2 == 0))
            {
                return -Fn;
            }
            else
            {
                return Fn;
            }


            //-67
            //            Test Failed
            //Expected: 44945570212853
            //But was:  -44945570212853
        }
    }
}
