using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factors(987654321));
            Console.ReadLine();
        }
        public static String factors(int lst)
        {
            string result="";
            int primesNum = 2;
            if (lst <= 1)
            {
                return lst.ToString();
            }
            for (int powerNum = 1; lst > 1; powerNum++)
            {
                if(lst%primesNum!=0)
                {
                    if (powerNum > 1)
                    {
                        result = FormatResult(result, primesNum, powerNum);
                    }
                    if (primesNum % 2 == 1)
                    {
                        while (lst % primesNum != 0 && primesNum * 2 < lst)
                            primesNum = FindNewPrimesNumber(primesNum);
                        if (primesNum * 2 > lst)
                            primesNum = lst;
                    }
                    else
                        primesNum++;
                    powerNum = 0;
                    continue;
                }
                if (lst / primesNum == 1)
                {
                    result = FormatResult(result, primesNum, powerNum+1);
                }
                lst = lst / primesNum;
            }
            return result;
        }

        private static string FormatResult(string result, int primesNum, int powerNum)
        {
            if (powerNum == 2)
            {
                result += "(" + primesNum + ")";
            }
            else
                result += "(" + primesNum + "**" + (powerNum - 1) + ")";
            return result;
        }

        private static int FindNewPrimesNumber(int primesNum)
        {
            bool m = true;
            
            while (m)
            {
                m = false;
                primesNum += 2;
                for (int n = 3; n < primesNum / 2; n+=2)
                {
                    if (primesNum % n == 0)
                    {
                        m = true;
                        break;
                    }
                }
            }

            return primesNum;
        }
    }
}
