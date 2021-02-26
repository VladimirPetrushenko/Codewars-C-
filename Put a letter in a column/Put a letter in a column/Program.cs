using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Put_a_letter_in_a_column
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BuildRowText(8, 'A'));
            Console.ReadLine();
        }
        public static string BuildRowText(int index, char character)
        {
            // Do your magic :)
            char[] s = "| | | | | | | | | |".ToCharArray();
            s[index*2 + 1] = character;
            return new string(s);
        }
    }
}
