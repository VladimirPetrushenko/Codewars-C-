using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Series_5_Triangular_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool isTriangular(int T)
        {
            // Good Luck ;)
            int m = 0;
            for(int i = 0; m < T; i++)
            {
                m += i;
            }
            return m == T;
        }
    }
}
