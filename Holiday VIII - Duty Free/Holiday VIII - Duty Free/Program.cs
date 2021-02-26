using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_VIII___Duty_Free
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            return hol * 100 / (normPrice * Discount);
        }
    }
}
