﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string FakeBin(string x)
        {
            return x.Replace('1', '0').Replace('2', '0').Replace('3', '0').Replace('4', '0').Replace('5', '1').Replace('6', '1').Replace('7', '1').Replace('8', '1').Replace('9', '1');
        }
    }
}
