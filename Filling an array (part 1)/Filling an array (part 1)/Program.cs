﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling_an_array__part_1_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] Arr(int N)
        {
            return Enumerable.Range(0,N).ToArray();
        }
    }
}
