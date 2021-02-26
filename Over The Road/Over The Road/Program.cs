using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Over_The_Road
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(overTheRoad(3,3));
            Console.ReadLine();
        }
        public static long overTheRoad(long address, long n)
        {
            return n * 2 - address + 1;
        }
    }
}
