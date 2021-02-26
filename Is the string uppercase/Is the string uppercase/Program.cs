using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_the_string_uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool IsUpperCase(this string text)
        {
            // your code here
            return text.Where(x => char.IsLower(x)).Count() == 0;
        }
    }
}
