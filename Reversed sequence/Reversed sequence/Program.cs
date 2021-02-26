using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] ReverseSeq(int n)
        {
           return Enumerable.Range(1,n).Reverse().ToArray();
        }
    }
}
