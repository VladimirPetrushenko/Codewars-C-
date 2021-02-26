using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_chain_length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(palindromeChainLength(89));
            Console.ReadLine();
        }
        public static int palindromeChainLength(int n)
        {
            if (n.ToString().Length == 1)
                return 0;
            long m = n;
            int i = 0;
            while(Convert.ToInt64(new string(m.ToString().ToArray())) != Convert.ToInt64(new string(m.ToString().ToArray().Reverse().ToArray())))
            {
                m = m + Convert.ToInt64(new string(m.ToString().ToArray().Reverse().ToArray()));
                i++;
            }
            return i;
        }
    }
}
