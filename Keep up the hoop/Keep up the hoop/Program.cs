using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_up_the_hoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HoopCount(10));
            Console.ReadLine();
        }
        public static string HoopCount(int n)
        {
            if (n >= 10)
            {
                return "Great, now move on to tricks";
            }
            return "Keep at it until you get it";
        }
    }
}
