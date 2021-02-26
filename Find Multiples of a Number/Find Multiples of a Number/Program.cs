using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Multiples_of_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var i in FindMultiples(5, 25))
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public static List<int> FindMultiples(int integer, int limit)
        {
            // Your code here!
            return Enumerable.Range(integer, limit - integer + 1).Where(x => x % integer == 0).ToList();
        }
    }
}
