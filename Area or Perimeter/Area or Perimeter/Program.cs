using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_or_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int AreaOrPerimeter(int l, int w)
        {
            // code goes here
            return l == w ? l * l : l + w + l + w;
        }
    }
}
