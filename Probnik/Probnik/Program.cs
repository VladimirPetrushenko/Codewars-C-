using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probnik
{
    class Program
    {
        static void Main(string[] args)
        {
            object s =null;
            double n;
            
            try
            {
                n = Convert.ToDouble(s?.ToString());
                Console.WriteLine(n);
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadLine();
        }
    }
}
