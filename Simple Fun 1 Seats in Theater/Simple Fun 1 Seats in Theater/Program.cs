using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Fun_1_Seats_in_Theater
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int SeatsInTheater(int nCols, int nRows, int col, int row)
        {
            //coding and coding...
            return (nCols - col + 1) * (nRows - row);
        }
    }
}
