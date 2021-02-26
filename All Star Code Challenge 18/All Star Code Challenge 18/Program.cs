using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Star_Code_Challenge_18
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int StrCount(string str, string letter)
        {
            //Do Some Magic
            return str.Split(new string[] { letter },StringSplitOptions.None).Count();
        }
    }
}
