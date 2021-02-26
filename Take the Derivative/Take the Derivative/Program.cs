using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_the_Derivative
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string Derive(double coefficient, double exponent)
        {
            return $"{coefficient * exponent}x^{exponent-1}";
        }
    }
}
