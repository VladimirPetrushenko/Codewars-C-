using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Nth_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int NthEven(int n)
        {
            //Your code
            return n > 0 ? n * 2 - 2 : 0;
        }
    }
}
