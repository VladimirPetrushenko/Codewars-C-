using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner___Lost_Without_a_Map
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var i in Maps(new[] { 1, 2, 3 }))
                Console.WriteLine(i);
            Console.ReadLine();
        }
        public static int[] Maps(int[] x)
        {
            return x.Select(m => m * 2).ToArray();
        }
    }
}
