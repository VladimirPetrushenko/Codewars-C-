using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPerfectPower
{
    class Program
    {
        static void Main(string[] args)
        {
            long m = 0;
            for (int i = int.MaxValue; i > 0; i--)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                (int, int)? n = IsPerfectPower(int.MaxValue);
                stopwatch.Stop();
                if (m < stopwatch.ElapsedMilliseconds)
                {
                    Console.WriteLine(stopwatch.ElapsedMilliseconds);
                    m = stopwatch.ElapsedMilliseconds;
                    Console.WriteLine(i);
                }
            }
            
            Console.ReadLine();
        }
        //public static (int, int)? IsPerfectPower(int n)
        //{
        //    SortedList<int, int> rz = new SortedList<int, int>();
        //    int i = 2;

        //    while (n > 1)
        //    {
        //        int j = 0;
        //        while (n % i == 0)
        //        {
        //            j++;
        //            if (j == 1)
        //            {
        //                rz.Add(i, j);
        //            }
        //            else
        //            {
        //                rz[i]++;
        //            }
        //            n = n / i;
        //        }
        //        i++;
        //    }
        //    SortedList<int, int> rc = new SortedList<int, int>();
        //    foreach(var m in rz.Keys)
        //    {
        //        if (rc.IndexOfKey(rz[m]) != -1)
        //        {
        //            rc[rz[m]] *= m;
        //        }
        //        else
        //        {
        //            rc.Add(rz[m], m);
        //        }
        //    }
        //    //foreach(var m in rc.Keys)
        //    //{
        //    //    Console.WriteLine("основание: " + rc[m] + "\nстепень " + m);
        //    //}
        //    int step = 1;
        //    int osn = 1;
        //    int result = 1;
        //    foreach(var m in rc.Keys)
        //    {
        //        result *= rc[m] * m / 2;
        //    }
        //    Console.WriteLine("основание: " + result + "\nстепень " + 2);
        //    return (rz.Keys[0], rz[rz.Keys[0]]);
        //}
        public static (int, int)? IsPerfectPower(int n)
        {
            List<(int, int)> rz = new List<(int, int)>();
            int i = 2;
            int step = 2; 
            int j = 0;
            bool f = false;
            bool m = false;
            int max = (int)Math.Floor((double)n / 2.0);
            while (i <=max )
            {
                while ((n % i) == 0 && n!=0)
                {
                    j++;
                    n = n / i;
                    f = true;
                }
                if (f)
                {
                    rz.Add((i, j));
                    f = false;
                    j = 0;
                }
                if (m)
                {
                    i+=2;
                }
                else
                {
                    i++;
                    m = true;
                }

            }
            if (rz.Count == 0)
            {
                return null;
            }
            else if (rz.Count > 1)
            {
                f = true;

                for (int i1 = 0; i1 < rz.Count; i1++)
                {
                    if (rz[i1].Item2 % 2 == 1) { f = false; }
                }
                if (f)
                {
                    int s = 1;
                    for (int i1 = 0; i1 < rz.Count; i1++)
                    {
                        s = s * (int)Math.Pow(rz[i1].Item1, rz[i1].Item2 / 2);
                    }
                    return (s, 2);
                }
                else
                {
                    f = true;

                    for (int i1 = 0; i1 < rz.Count; i1++)
                    {
                        if (rz[i1].Item2 % 2 == 0)
                        {
                            rz[i1] = (rz[i1].Item1 * rz[i1].Item1, rz[i1].Item2 / 2);
                        }
                    }
                    for (i = 0; i <= rz.Count - 2; i++)
                    {
                        if (rz[i].Item2 != rz[i + 1].Item2) { f = false; }
                        if (rz[i].Item2 == 1) { f = false; }
                    }
                    if (f)
                    {
                        int s = 1;
                        for (int i1 = 0; i1 < rz.Count; i1++)
                        {
                            s = s * rz[i1].Item1;
                        }
                        return (s, rz[0].Item2);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else if (rz.Count == 1 && rz[0].Item2 == 1)
            {
                return null;
            }
            else 

            {
                return ((rz[0].Item1, rz[0].Item2));
            }
            
        }

    }
}
