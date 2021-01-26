using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    class Cavallo : Quadrupede
    {
        public Cavallo(string s) : base(s)
        {
            verso = "nitrisce";
        }

        public override string chi_sei()
        {
            return "un cavallo";
        }
    }
}
