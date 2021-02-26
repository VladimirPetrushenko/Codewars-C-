using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_it_even
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsEven(double n)
        {
            // Your awesome code here!
            return Math.Ceiling(n) % 2 == 0;
        }
    }
}
