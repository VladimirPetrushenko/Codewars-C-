using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumIntervals(new (int, int)[] { (2, 5), (-1, 2), (-40, -35), (6, 8) }));
            Console.ReadLine();
        }
        public static int SumIntervals((int , int)[] intervals)
        {
            try
            {
                int maxItem1 = intervals.Max().Item1;
                int minItem1 = intervals.Min().Item1;
                int maxItem2 = intervals[0].Item2;
                int minItem2 = intervals[0].Item2;
                for (int i = 1; i < intervals.Length; i++)
                {
                    if(maxItem2 < intervals[i].Item2)
                    {
                        maxItem2 = intervals[i].Item2;
                    }
                    if (minItem2 > intervals[i].Item2)
                    {
                        minItem2 = intervals[i].Item2;
                    }
                }
                int CountMass = 0;
                int choise = 0;
                if (minItem1 < 0 || minItem2 < 0)
                {
                    CountMass = Math.Abs(Math.Min(minItem2, minItem1)) + Math.Max(maxItem1, maxItem2)+1;
                    choise = Math.Abs(Math.Min(minItem2, minItem1));
                }
                else
                {
                    CountMass = Math.Max(maxItem1, maxItem2);
                }
                int[] mass = new int[CountMass];
                for (int i = 0; i < intervals.Length; i++)
                {
                    if (Math.Min(intervals[i].Item1, intervals[i].Item2) > 0)
                    {
                        for (int j = choise + Math.Min(intervals[i].Item1,intervals[i].Item2); j < choise + Math.Max(intervals[i].Item1, intervals[i].Item2); j++)
                        {
                            mass[j] = 1;
                        }
                    }
                    else
                    {
                        for (int j = Math.Min(intervals[i].Item1, intervals[i].Item2); j < Math.Max(intervals[i].Item1, intervals[i].Item2); j++)
                        {
                            mass[choise + j] = 1;
                        }
                    }
                }
                return mass.Sum();
            }
            catch
            {
                return 0;
            }
        }
    }
}
