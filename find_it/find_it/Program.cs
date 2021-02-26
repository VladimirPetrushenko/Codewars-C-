using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_it
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vs = new[] { 5, 5, 4, 5, 4 };
            int result = 0;
            for(int i = 0; i < vs.Length; i++)
            {
                int number = vs[i];
                int count = 1;
                for(int j = 0; j < vs.Length; j++)
                {
                    if(number==vs[j] && j != i)
                    {
                        count++;
                    }
                }
                if (count % 2 != 0)
                {
                    result = vs[i];
                    break;
                }
            }
            Console.WriteLine(result);
            Console.WriteLine(vs.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key);
            int found = 0;
            foreach (var num in vs)
            {
                found ^= num;
            }
            Console.WriteLine(found);
            Console.ReadLine();
        }
    }
}
