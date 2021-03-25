using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_022_Scopa
{
    class Carta
    {
        private int valore;
        private string seme;

        public Carta(int valore, string seme)
        {
            this.valore = valore;
            this.seme = seme;
        }

        public void Lettura(int valore, string seme)
        {
            seme = this.seme;
            valore = this.valore;
        }
    }
}
