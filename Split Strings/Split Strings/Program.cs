using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("abc"));
            Console.ReadLine();
        }
        public static string[] Solution(string str)
        {
            List<string> list = new List<string>();
            while (str.Length >= 2)
            {
                list.Add(str.Substring(0, 2));
                str = str.Remove(0, 2);
            }
            if (str.Length == 1)
            {
                str += "_";
                list.Add(str);
            }
            return list.ToArray();
        }
    }
}
