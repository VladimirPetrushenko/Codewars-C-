using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DrawStairs(7));
            Console.ReadLine();
        }
        public static string DrawStairs(int n)
        {
            // Happy coding ;)
            string s = "I";
            string spase = "";
            for(int i = 1; i < n; i++)
            {
                spase += " ";
                s += "\n" + spase + "I";
            }
            return s;
        }
    }
}
