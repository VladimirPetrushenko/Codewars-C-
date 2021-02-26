using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Extract(new[] { 41, 43, 44, 46, 47 }));
            Console.ReadLine();
        }
        public static string Extract(int[] args)
        {
            int firstSumbol = Math.Abs(args[0] - args[1]) > 1? 0: 1;
            string outLine = args[0].ToString();
            byte openFor = 0;
            for(int i = 1; i < args.Length - 1; i++)
            {
                if (Math.Abs(args[i] - args[i + 1]) == 1)
                {
                    firstSumbol++;
                    if (firstSumbol == 2)
                    {
                        outLine += "-";
                    }
                    if (firstSumbol == 1 && Math.Abs(args[i-1] - args[i]) != 1)
                    {
                        outLine += "," + args[i];
                    }
                }
                else
                {
                    if (firstSumbol > 0)
                    {
                        if (firstSumbol == 1)
                        {
                            outLine += ",";
                        }
                        outLine += args[i];
                        firstSumbol = 0;
                    }
                    else
                    {
                        outLine += "," + args[i];
                    }
                }
                if(openFor<3)
                    openFor++;
            }
            if (openFor == 0)
            {
                outLine += ",";
            }
            if (openFor == 1)
            {
                outLine += "-";
            }
            outLine += args[args.Length-1].ToString();
            return outLine;  //TODO
        }
    }
}
