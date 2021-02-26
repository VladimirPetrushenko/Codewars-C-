using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Century_From_Year
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int СenturyFromYear(int year)
        {
            return (year-1)/100+1;
        }
    }
}
