using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    public abstract class PesceDiMare : AnimaleMarino
    {
        public PesceDiMare(string s) : base(s)
        {
        }

        public override string vive()
        {
            return "in mare";
        }

        public override string chi_sei()
        {
            return "un pesce di mare";
        }
    }
}
