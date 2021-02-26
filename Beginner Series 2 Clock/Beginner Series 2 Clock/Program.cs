using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Series_2_Clock
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int Past(int h, int m, int s)
        {
            //#Happy Coding! ^_^
            return (h * 60 * 60 + m * 60 + s) * 1000;
        }
    }
}
