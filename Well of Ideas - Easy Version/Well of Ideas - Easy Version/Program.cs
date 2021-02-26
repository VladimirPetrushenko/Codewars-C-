using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Well_of_Ideas___Easy_Version
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Well(new string[] { "good", "good", "good" }));
            Console.ReadLine();
        }
        public static string Well(string[] x)
        {
            return x.Where(str => str == "good").Count() > 2 ? "I smell a series!" : (x.Where(str => str == "good").Count() == 0 ? "Fail!" : "Publish!");
        }
    }
}
