using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_a_pile_of_Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findNb(4183059834009));
            long n = 0;
            long result = 0;
            while (n < 2022)
            {
                n++;
                result += n*n*n;
            }
            Console.WriteLine(result);
            Console.WriteLine(4183059834009);
            Console.WriteLine(n);
            Console.ReadLine();
        }
        public static long findNb(long m)
        {
            // your code
            long n = 0;
            long sum = 0;
            while (sum<m)
            {
                n++;
                sum += n * n * n;
            }
            
            if (sum > m)
            {
                return -1;
            }
            else 
            {
                return n;
            }
        }
    }
}
