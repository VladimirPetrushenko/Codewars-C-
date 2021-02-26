using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_duplicates_from_list
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] distinct(int[] a)
        {
            return a.Distinct().ToArray();
        }
    }
}
