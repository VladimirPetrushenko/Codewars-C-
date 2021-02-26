using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_Bartender__drinks_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static string GetDrinkByProfession(string p)
        {
            switch (p.ToLower())
            {
                case "jabroni": return "Patron Tequila";
                case "school counselor": return "Anything with Alcohol";
                case "programmer": return "Hipster Craft Beer";
                case "bike gang member": return "Moonshine";
                case "politician": return "Your tax dollars";
                case "rapper": return "Cristal";
                default: return "Beer";
            }
        }
    }
}
