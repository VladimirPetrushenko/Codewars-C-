using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exclusive_or__xor__Logical_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Xor(false, false));
            Console.ReadLine();
        }
        public static bool Xor(bool a, bool b)
        {
            return a^b;
        }
    }
}
