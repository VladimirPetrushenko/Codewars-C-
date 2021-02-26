using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Are_You_Playing_Banjo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string AreYouPlayingBanjo(string name)
        {
            //Implement me
            return name[0] == 'R' || name[0] == 'r' ? name + " plays banjo" : name + " does not play banjo";
        }
    }
}
