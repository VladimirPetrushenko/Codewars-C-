using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_VI___Shark_Pontoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Shark(21, 68, 3, 9, false));
            Console.ReadLine();
        }
        public static string Shark(int pontoonDistance,
                                  int sharkDistance,
                                  int yourSpeed,
                                  int sharkSpeed,
                                  bool dolphin)
        {
            //your code here
            Console.WriteLine((double)pontoonDistance / yourSpeed);
            Console.WriteLine((double)sharkDistance / sharkSpeed);
            return dolphin ? (double)pontoonDistance / yourSpeed <= (double)sharkDistance / (sharkSpeed / 2) ? "Alive!" : "Shark Bait!" 
                            : (double)pontoonDistance / yourSpeed <= (double)sharkDistance / sharkSpeed ? "Alive!" : "Shark Bait!";
        }
    }
}
