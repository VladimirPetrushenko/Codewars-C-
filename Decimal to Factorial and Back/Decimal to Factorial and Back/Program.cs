using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Factorial_and_Back
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string D2Str(long n)
        {
            if (n < 10)
            {
                return n.ToString();
            }
            else
            {
                char c = (char)(n + 55);
                return c.ToString();
            }
        }
        public static long Str2D(char c)
        { //char c = s.ElementAt(0); 
            if (Enumerable.Range('A', 'Z' - 'A' + 1).Contains(c))
            {
                return (long)(c - 55);
            }
            else
            {
                string s = c.ToString();
                return long.Parse(s);
            }
        }
        public static string dec2FactString(long nb)
        {
            string s = "";
            List<long> list = new List<long> { };
            long i = 0;
            while (nb > (i + 1))
            {
                i++; 
                list.Add(nb % i);
                nb = nb / i;
            }
            if (nb > 1)
            {
                list.Add(nb);
            }
            s = string.Concat(list.ToArray().Reverse().ToArray());
            //list.ToArray().Reverse().ToArray();
            //foreach (var x in list)
            //{
            //    s = D2Str(x) + s;
            //}
            return s;
        }
        public static long factString2Dec(string str)
        {
            long n = Str2D(str[0]) * (str.Length - 1); str = str.Remove(0, 1);
            while (str != "0")
            { //((((3×5 + 4)×4 + 1)×3 + 0)×2 + 1)×1 + 0 
                n = (n + Str2D(str[0])) * (str.Length - 1);
                str = str.Remove(0, 1);
            }
            return n;
        }
    }
}
