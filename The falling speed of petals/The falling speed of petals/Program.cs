using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_falling_speed_of_petals
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static double SakuraFall(double v)
        {
            return v > 0 ? 400.0 / v : 0;
        }
    }
}
