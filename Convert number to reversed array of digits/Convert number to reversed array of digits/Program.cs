using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_number_to_reversed_array_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static long[] Digitize(long n)
        {
            // Code goes here
            return n.ToString().Reverse().Select(el=> Convert.ToInt64(el.ToString())).ToArray();
        }
    }
}
