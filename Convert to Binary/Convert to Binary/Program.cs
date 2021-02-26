using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToBinary(5));
            Console.ReadLine();
        }
        public static int ToBinary(int n)
        {
            return Convert.ToInt32(Convert.ToString(n,2));
        }
    }
}
