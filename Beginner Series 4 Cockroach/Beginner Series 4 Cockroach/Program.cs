using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Series_4_Cockroach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CockroachSpeed(1.09));
            Console.ReadLine();
        }
        public static int CockroachSpeed(double x)
        {
            //#Happy Coding! ^_^
            return Convert.ToInt32(x * 1000 / 36);
        }
    }
}
