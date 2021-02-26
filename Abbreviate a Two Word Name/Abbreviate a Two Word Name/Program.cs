using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbreviate_a_Two_Word_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            AbbrevName("Name Spase");
            Console.ReadLine();
        }
        public static string AbbrevName(string name)
        {
            
            return string.Concat(char.ToUpper(name.Split(' ').ElementAt(0).ElementAt(0)), '.', char.ToUpper(name.Split(' ').ElementAt(1).ElementAt(0)));
        }
    }
}
