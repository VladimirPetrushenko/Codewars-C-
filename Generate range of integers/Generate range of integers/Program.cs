using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_range_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var i in GenerateRange(1, 10, 5))
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public static int[] GenerateRange(int min, int max, int step)
        {
            // your code goes here
            return Enumerable.Range(min, max - min + 1).Where(x => (x-min) % step == 0).ToArray();
        }
    }
}
