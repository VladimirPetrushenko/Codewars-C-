using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_I_get_a_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bonus_time(10000,false));
            Console.ReadLine();
        }
        public static string bonus_time(int salary, bool bonus)
        {
            // your code
            return "$" + (bonus ? (salary * 10).ToString() : salary.ToString());
        }
    }
}
