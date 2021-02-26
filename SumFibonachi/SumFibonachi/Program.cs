using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SumFibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = 6002082144827584330;
            n = n * 1000 + 3104;
            //for (int i = 0; i < 1000; i++)
            //{
            //    if(Fibonachi(i)==m || Fibonachi(i) == n)
                    //Console.WriteLine(Fibonachi(1800) + "    ");
            //}
            n = (BigInteger)Fibonachi(1800);
            double m = double.MaxValue;
            Console.WriteLine(n);
            Console.WriteLine(m);
            n = (BigInteger)m + (BigInteger)m + (BigInteger)m + (BigInteger)m + (BigInteger)m;
            Console.WriteLine(n);
            Console.WriteLine(double.MaxValue);
            Console.ReadLine();
        }
        public static BigInteger Fibonachi(BigInteger n)
        {
            BigInteger m = new BigInteger(1);
            if (n <  1470)
            {
                m = (BigInteger)(((Math.Pow((1 + Math.Sqrt(5)) / 2, (double)n + 3) - Math.Pow((1 - Math.Sqrt(5)) / 2, (double)n + 3)) / Math.Sqrt(5) - 1) * 4);
            }
            else
            {
                BigInteger a = 1;
                BigInteger sum = 1;
                for (int i = 0; i < n; i++)
                {
                    sum = sum + a;
                    a = m;
                    m = sum;
                }
                //m = BigInteger.Pow((BigInteger)((1 + Math.Sqrt(5)) / 2), (int)n + 2); //- BigInteger.Pow((BigInteger)((1 - Math.Sqrt(5)) / 2), (int)n + 2)) / (BigInteger)Math.Sqrt(5) - 1;
            }
                return m;
            
           /* catch
            {
                return (BigInteger.Pow((BigInteger)((1 + Math.Sqrt(5)) / 2), n + 2) - BigInteger.Pow((BigInteger)((1 - Math.Sqrt(5)) / 2), n + 2)) / (BigInteger)Math.Sqrt(5) - 1;
            }*/
        }
        public static double Fibonachi1(int n)
        {
            return ((((double)Math.Pow((1 + Math.Sqrt(5)) / 2, n + 3) - (double)Math.Pow((1 - Math.Sqrt(5)) / 2, n + 3)) / (double)Math.Sqrt(5) - 1) * 4);
        }
    }
}
