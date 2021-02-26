using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hands = GetPositions(27);
            foreach(var i in hands)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public static int[] GetPositions(int s)
        {
            // your code
            int[] hands = new int[] { 0, 0, 0 };
            s = s % 27;
            s++;
            for (int i = 1; s>0 ; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    for (int m = 0; m < 3 && s > 0; m++)
                    {
                        hands[0] = m;
                        s--;
                    }
                    if (s == 0)
                    {
                        break;
                    }
                    hands[1] = j % 3;
                }
                if (s == 0)
                    break;
                hands[2] = i % 3;
            }
            return hands;
        }
    }
}
