using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Partridge_2___Apple_Turnover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Apple(4));
            Console.ReadLine();
        }
        public static string Apple(object n)
        {
            return Math.Pow(Convert.ToInt32(n), 2) > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
        }
    }
}
