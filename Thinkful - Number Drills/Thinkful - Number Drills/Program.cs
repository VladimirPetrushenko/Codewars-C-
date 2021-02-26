using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinkful___Number_Drills
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GuessBlue(5, 5, 2, 3));
            Console.ReadLine();
        }
        public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
        {
            // Code goes here..
            return (blueStart-bluePulled) * 1.0 / (blueStart - bluePulled + redStart - redPulled);
        }
    }
}
