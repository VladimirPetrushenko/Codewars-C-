using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grasshopper___Check_for_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckForFactor(10,2));
        }
        public static bool CheckForFactor(int num, int factor)
        {
            // code here
            return num % factor == 0;
        }
    }
}
