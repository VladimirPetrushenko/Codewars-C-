using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_The_Parity_Outlier
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int[] mass = new int[] { 160, 3, 1719, 19, 11, 13, -21 };
            

            Console.WriteLine(Find(mass));
            Console.ReadLine();
        }
        public static int Find(int[] integers)
        {
            if (integers[0] % 2 == 1)
            {
                if (integers[1] % 2 == 1)
                {
                    for (int i = 2; i < integers.Length; i++)
                    {
                        if (integers[i] % 2 == 0)
                        {
                            return integers[i];
                        }
                    }
                }
                else if (integers[2] % 2 == 1)
                {
                    return integers[1];
                }
            }
            else if (integers[1] % 2 == 0)
            {
                for (int i = 2; i < integers.Length; i++)
                {
                    if (integers[i] % 2 == 1)
                    {
                        return integers[i];
                    }
                }
            } else if (integers[2] % 2 == 0)
            {
                return integers[1];
            }
            else { return integers[0]; }
            return -1;
        }
    }
}
