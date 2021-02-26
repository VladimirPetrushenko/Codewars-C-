using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grasshopper___Grade_book
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static char GetGrade(int s1, int s2, int s3)
        {
            //Your code goes here...
            double average = (s1 + s2 + s3) / 3.0;
            return average >= 90 ? 'A' : average >= 80 ? 'B' : average >= 70 ? 'C' : average >= 60 ? 'D' : 'F';
        }
    }
}
