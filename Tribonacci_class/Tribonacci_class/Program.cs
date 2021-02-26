using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci_class
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
            {
                return new double[0];
            }
            List<double> s = new List<double>();
            s.AddRange(signature);
            while (s.Count < n)
            {
                s.Add(s[s.Count - 1] + s[s.Count - 2] + s[s.Count - 3]);
            }
            return s.ToArray();
            // hackonacci me
        }
    }
}
