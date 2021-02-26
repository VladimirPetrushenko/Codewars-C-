using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Convert_string_to_camel_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the-stealth-warrior-"));
            Console.ReadLine();
            string input = "the-stealth-warrior-";
        }
        public static string ToCamelCase(string str)
        {
            return Regex.Replace( Regex.Replace(str, @"[-_](\S)", value => value.Groups[1].ToString().ToUpper()), @"[-_]", "");
        }
    }
}
