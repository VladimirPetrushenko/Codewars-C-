using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.ReadLine();
        }
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            if (t < 0 || k < 1 || ls.Count < k || ls.Where(x => x < 0).Count() > 0)
            {
                return null;
            }
            int max = 0;
            int[] skemSum = new int[k + 1];
            List<int> outM = new List<int>();
            for (int i = 0; i <= ls.Count - k; i++)
            {
                List<int> m = new List<int>();
                if (k > 2)
                {
                    for (int j = i; j <= ls.Count - k; j++)
                        Sum(k - 1, ls, j + 1, m, skemSum);
                    foreach (var n in m)
                    {
                        outM.Add(ls[i] + n);
                    }
                }
                else if (k == 2)
                {
                    for (int j = i; j <= ls.Count - k; j++)
                        m.Add(Sum(k - 1, ls, j + 1, m, skemSum));
                    foreach (var n in m)
                    {
                        outM.Add(ls[i] + n);
                    }
                }
                else
                {
                    outM.Add(ls[i]);
                }
            }
            foreach (var n in outM)
            {
                if (n > max && n <= t)
                {
                    max = n;
                }
            }
            return max;
            // your code
        }
        
        public static int Sum(int glubinaRecursii, List<int> ishondiMassiv, int indexS, List<int> summaRastoyanii, int[] skemSum)
        {
            skemSum[glubinaRecursii] = 0;
            if (glubinaRecursii == 1)
            {
                return ishondiMassiv[indexS];
            }
            skemSum[glubinaRecursii + 1] = 0;
            for (int i = indexS; i <= ishondiMassiv.Count - glubinaRecursii; i++)
            {
                if (glubinaRecursii == 2)
                {
                    skemSum[glubinaRecursii]++;
                    summaRastoyanii.Add(ishondiMassiv[indexS] + Sum(glubinaRecursii - 1, ishondiMassiv, i + 1, summaRastoyanii, skemSum));
                }
                else
                {
                    skemSum[glubinaRecursii] = Sum(glubinaRecursii - 1, ishondiMassiv, i + 1, summaRastoyanii, skemSum);
                    int j = 1;
                    do
                    {
                        summaRastoyanii[summaRastoyanii.Count - j] = summaRastoyanii[summaRastoyanii.Count - j] + ishondiMassiv[indexS];
                        j++;
                    } while (j <= skemSum[glubinaRecursii]);
                    skemSum[glubinaRecursii + 1] += skemSum[glubinaRecursii];
                }
            }
            if (glubinaRecursii == 2)
                return skemSum[glubinaRecursii];
            else
                return skemSum[glubinaRecursii + 1];
        }
    }
}
