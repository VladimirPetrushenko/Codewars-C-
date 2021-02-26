using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_there_be_enough_space
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int Enough(int cap, int on, int wait)
        {
            return cap - on - wait >= 0 ? 0 : wait - (cap - on);
        }
    }
}
