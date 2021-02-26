using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Last_digit_of_a_huge_number
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(LastDigit(new int[] { 82242, 254719, 736371 }));
            Console.ReadLine();
        }
        public static int LastDigit(int[] array)
        {
            if (array.Length < 1)
            {
                return 1;
            }
            if (array.Length == 1)
            {
                return array[0] % 10;
            }
            int result = array[array.Length-1];
            for (int i = array.Length - 2; i >= 0; i--)
            {
                int step1 = array[i] % 20;
                if (step1 == 0 && array[i] != 0)
                {
                    step1 = 10;
                }
                int step2 = result % 4;
                if (result >= 4 || array[i+1] >= 4) 
                    step2 += 4;
                result = (int)Math.Pow(step1, step2);
            }
            return result % 10;
        }
    }
}
