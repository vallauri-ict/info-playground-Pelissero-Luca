using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    class Corvo : Uccello
    {
        public Corvo(string s) : base(s)
        {
            verso = "gracchia";
        }

        public override string chi_sei()
        {
            return "un corvo";
        }
    }
}
