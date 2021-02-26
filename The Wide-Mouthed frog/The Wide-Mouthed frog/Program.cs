using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Wide_Mouthed_frog
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string MouthSize(string animal)
        {
            // code here
            return animal.ToLower() == "alligator" ? "small" : "wide";
        }
    }
}
