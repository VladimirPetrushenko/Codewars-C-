using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_the_mean_of_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int GetAverage(int[] marks)
        {
            // ...
            return Convert.ToInt32(Math.Floor(marks.Average()));
        }
    }
}
