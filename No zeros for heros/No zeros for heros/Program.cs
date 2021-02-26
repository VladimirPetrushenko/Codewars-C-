using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_zeros_for_heros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoBoringZeros(960000));
            Console.ReadLine();
        }
        public static int NoBoringZeros(int n)
        {
            // your code
            for(int i = 0; n!=0; i++)
            {
                if (n.ToString().LastIndexOf("0") == n.ToString().Length - 1)
                {
                    n = Convert.ToInt32(n.ToString().Remove(n.ToString().Length - 1));
                }
                else
                    break;
            }
            return n;
        }
    }
}
