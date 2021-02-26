using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_numbers_which_are_divisible_by_given_number
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            return numbers.Where(x => x % divisor == 0).ToArray();
        }
    }
}
