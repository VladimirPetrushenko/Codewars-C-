using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_unique_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetUnique(new[] {0, 0, 2, 1, 2, 2, 2 }));
            Console.ReadLine();
        }
        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.Where(x => numbers.Count(p => p == x) == 1).First(); //your code
        }
        public class Number
        {
            public int key;
            public int count;
            public Number()
            {
                key = 0;
                count = 0;
            }
        }
    }
}
