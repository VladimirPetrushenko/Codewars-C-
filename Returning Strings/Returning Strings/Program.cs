using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Returning_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }
    }
}
