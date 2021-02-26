using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_you_make_it
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            return mpg * fuelLeft >= distanceToPump;
        }
    }
}
