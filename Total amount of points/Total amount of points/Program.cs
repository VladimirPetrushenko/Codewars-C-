using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_amount_of_points
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int TotalPoints(string[] games)
        {
            // insert magic here
            int result = 0;
            foreach(var x in games)
            {
                if (int.Parse(x.Split(':').ElementAt(0)) > int.Parse(x.Split(':').ElementAt(1)))
                    result += 3;
                else if (int.Parse(x.Split(':').ElementAt(0)) == int.Parse(x.Split(':').ElementAt(1)))
                    result += 1;
            }
            return result;
        }
    }
}
