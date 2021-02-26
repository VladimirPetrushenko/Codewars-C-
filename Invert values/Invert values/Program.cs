using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invert_values
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] InvertValues(int[] input)
        {
            //Code it!
            return input.Select(x => x = -x).ToArray();
        }
    }
}
