using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dollars_and_Cents
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string FormatMoney(double amount)
        {
            // your formatting code here
            return "$" + amount.ToString("0.00:C");
        }
    }
}
