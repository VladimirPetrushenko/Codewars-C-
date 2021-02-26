using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_good_are_you_really
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            //Insert brain here
            return (ClassPoints.Sum()+YourPoints)/(ClassPoints.Count()+1) < YourPoints;
        }
    }
}
