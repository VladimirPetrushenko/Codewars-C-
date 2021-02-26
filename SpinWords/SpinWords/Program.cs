using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( SpinWords("This is a testss") );
            Console.ReadLine();
        }
        public static string SpinWords(string sentence)
        {
            string[] lines = sentence.Split(' ');
            for(int i=0; i < lines.Length; i++)
            {
                if (lines[i].Length >= 5)
                {
                    char[] arr = lines[i].ToArray();
                    Array.Reverse(arr);
                    lines[i] =new string(arr);
                }
            }
            string result = string.Join(" ", lines);
            return result;
        }
    }
}
