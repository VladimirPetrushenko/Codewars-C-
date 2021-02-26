using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Fun_15_Addition_without_Carrying
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AdditionWithoutCarrying(456,1734));
            Console.ReadLine();
        }
        public static int AdditionWithoutCarrying(int a, int b)
        {
            //coding and coding..
            string aStr = a.ToString();
            string bStr = b.ToString();
            string result = "";
            for(int i = 0; i < Math.Min(aStr.Length, bStr.Length); i++)
            {
                result += (aStr[aStr.Length - i - 1]-'0' + bStr[bStr.Length - i - 1]- '0').ToString().ToArray().Last();
            }
            if (aStr.Length > bStr.Length)
            {
                for(int i = bStr.Length; i < aStr.Length; i++)
                {
                    result += aStr[aStr.Length - i - 1] - '0';
                }
            }
            if (aStr.Length < bStr.Length)
            {
                for (int i = aStr.Length; i < bStr.Length; i++)
                {
                    result += bStr[bStr.Length - i - 1] - '0';
                }
            }
            return Convert.ToInt32(new string(result.Reverse().ToArray()));
        }
    }
}
