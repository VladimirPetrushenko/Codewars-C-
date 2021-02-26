using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
            Console.ReadLine();
        }
        public static int Solution(int value)
        {
            var sum = 0;
            for (int i = 3; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            return sum;
        }
    }
}
