using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    class Uccello : Bipede
    {
        public Uccello(String s) : base(s)
        {
            verso = "cinguetta";
        }

        public override string chi_sei()
        {
            return "un uccello";
        }

        public override string si_muove()
        {
            return "volando";
        }

        public override string vive()
        {
            return "in un nido su un albero";
        }
    }
}
