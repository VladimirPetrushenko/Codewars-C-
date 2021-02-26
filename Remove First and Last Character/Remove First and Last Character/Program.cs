using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_First_and_Last_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Remove_char("eloquent"));
            Console.ReadLine();
        }
        public static string Remove_char(string s)
        {
            // Your Code
            return s.Length >= 2 ? new string(s.Where((x, i) => i != 0 & i != s.Length - 1).ToArray()) : s;  
        }
    }
}
