using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    class Uomo : Bipede
    {
        public Uomo(string s) : base(s)
        {
            verso = "parla";
        }

        public override string chi_sei()
        {
            return "un homo sapiens";
        }

        public override string vive()
        {
            return "in un condominio";
        }
    }
}
