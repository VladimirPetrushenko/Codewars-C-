using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateTip(20, "Excellent"));
            Console.ReadLine();
        }
        public static int CalculateTip(double amount, string rating)
        {
            return rating.ToLower() == "terrible" ? Convert.ToInt32(Math.Ceiling(amount * 0))
                   : rating.ToLower() == "poor" ? Convert.ToInt32(Math.Ceiling(amount * 0.05))
                   : rating.ToLower() == "good" ? Convert.ToInt32(Math.Ceiling(amount * 0.1))
                   : rating.ToLower() == "great" ? Convert.ToInt32(Math.Ceiling(amount * 0.15))
                   : rating.ToLower() == "excellent" ? Convert.ToInt32(Math.Ceiling(amount * 0.2))
                   : -1;
        }
    }
}
