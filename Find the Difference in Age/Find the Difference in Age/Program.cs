using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Difference_in_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var i in DifferenceInAges(new int[] { 82, 15, 6, 38, 35 }))
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public static int[] DifferenceInAges(int[] ages)
        {
            return new int[] { ages.Min(), ages.Max(), ages.Max() - ages.Min() };
        }
    }
}
