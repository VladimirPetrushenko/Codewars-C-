using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueInOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = "WUBWUBWUBWEWUBAREWUBWUBWUBWUBWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB";
            char[] vs1 = m.ToCharArray();
            char[] vs = (char[])Program.UniqueInOrders<char>(vs1);
            //int[] vs = (int[])UniqueInOrders<int>(new int[5] { 1, 2, 2, 3, 3 });
            foreach (var v in vs)
            {
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }
        public static IEnumerable<T> UniqueInOrders<T>(IEnumerable<T> iterable)
        {
             
            T[] item1 = iterable.ToArray();
            int indexResult = 0;
            foreach (var item in iterable)
            {
                if (item1[indexResult].ToString() != item.ToString())
                {
                    indexResult++;
                    item1[indexResult] = item;
                }
            }
            indexResult++;
            if (indexResult > 1)
            {
                T[] result = new T[indexResult];
                for (int i = 0; i < indexResult; i++)
                {
                    result[i] = item1[i];
                }
                return result;
            }
            else
                return iterable;
        }
        
    }
}
