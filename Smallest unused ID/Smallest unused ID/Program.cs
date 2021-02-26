using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_unused_ID
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int NextId(int[] ids)
        {
            //this will be awesome!
            Array.Sort(ids);
            return ids[0] > 0 ? 0 : ids.Where((x, i) => x == i).Last()+1;
        }
    }
}
