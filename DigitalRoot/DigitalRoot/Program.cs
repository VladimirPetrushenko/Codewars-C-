using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 493193;
            string s = n.ToString();
            byte[] m = new byte [s.Length];
            int count = 0;
            for (int i = 0;; i++)
            {
                if(i == s.Length)
                {
                    if (count > 9)
                    {
                        i = -1;
                        s = count.ToString();
                        count = 0;
                        continue;
                    }
                    break;
                }
                m[i] = Byte.Parse(s[i].ToString());
                count += m[i];
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
