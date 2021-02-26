using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_th_Power
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static double Index(int[] array, int n)
        {
            return n >= array.Length ? -1 : Math.Pow(array[n], n);
        }
    }
}
