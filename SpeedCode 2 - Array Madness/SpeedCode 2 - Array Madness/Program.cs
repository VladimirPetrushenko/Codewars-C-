using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCode_2___Array_Madness
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool ArrayMadness(int[] a, int[] b)
        {
            // Ready, get, set, GO!!!
            return a.Select(m => m * m).Sum() > b.Select(m => m * m * m).Sum(); 
        }
    }
}
