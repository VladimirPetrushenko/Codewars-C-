using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_plus_array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            return arr1.Sum()+arr2.Sum();
        }
    }
}
