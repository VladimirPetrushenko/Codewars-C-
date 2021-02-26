using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace You_only_need_one___Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check(new object[] { 66, 101 }, 66));
            Console.ReadLine();
        }
        public static bool Check(object[] a, object x)
        {
            return a.Where(m => m.Equals(x)).Count()>0;
        }
    }
}
