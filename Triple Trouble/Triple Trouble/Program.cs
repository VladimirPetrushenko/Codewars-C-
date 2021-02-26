using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Trouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TripleTrouble("aa","bb","cc"));
            Console.ReadLine();
        }
        public static string TripleTrouble(string one, string two, string three)
        {
            //Solution
            string str = "";
            for(int i=0; i < one.Length; i++)
            {
                str += one.ElementAt(i).ToString() + two.ElementAt(i).ToString() + three.ElementAt(i).ToString();
            }
            return str;
        }
    }
}
