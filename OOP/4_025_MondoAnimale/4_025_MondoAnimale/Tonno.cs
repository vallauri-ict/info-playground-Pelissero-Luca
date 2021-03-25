using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    class Tonno : PesceDiMare
    {
        public Tonno(string s) : base(s)
        {
            verso = "non fa versi";
        }

        public override string chi_sei()
        {
            return "tonno";
        }

        public override string si_muove()
        {
            return "nuotando";
        }
    }
}
