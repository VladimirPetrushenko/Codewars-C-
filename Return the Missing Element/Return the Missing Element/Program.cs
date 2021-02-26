using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_the_Missing_Element
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int GetMissingElement(int[] superImportantArray)
        {
            //TODO
            
            int i;
            for (i = 0; i <= 9; i++)
            {
                if(superImportantArray.Where(x=> x == i).Count() == 0)
                {
                    break;
                }
            }
            return i;
        }
    }
}
