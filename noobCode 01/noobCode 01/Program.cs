using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noobCode_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SuperSize(123456));
            Console.ReadLine();
        }
        public static long SuperSize(long num)
        {
            if (num.ToString().Count() == 1 || num == int.MaxValue)
                return  num;
            char[] m = num.ToString().ToArray();
            for (int j = num.ToString().Length - 1; j>0; j--) {
                for (int i = 0; i < j; i++)
                {
                    if (m[i] < m[i+1])
                    {
                        char n = m[i];
                        m[i] = m[i + 1];
                        m[i + 1] = n;
                    }

                }
            }
            return Convert.ToInt64(new string(m));
        }
    }
}
