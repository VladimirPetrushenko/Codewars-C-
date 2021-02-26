using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_s_the_real_floor
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int GetRealFloor(int n)
        {
            return n <= 0 ? 0 : n < 14 ? n - 1 : n - 2;
        }
    }
}
