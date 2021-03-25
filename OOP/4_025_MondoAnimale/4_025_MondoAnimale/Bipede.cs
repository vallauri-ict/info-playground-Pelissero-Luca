using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    public abstract class Bipede : AnimaleTerrestre
    {
        public Bipede(string s) : base(s)
        {
        }

        public override string si_muove()
        {
            return "camminando su 2 gambe";
        }
    }
}
