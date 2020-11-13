using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_5___oop01
{
    class Fatture
    {
        private static int cntFatture = 0;
        public readonly int nFattura;

        public Fatture()
        {
            cntFatture++;
            this.nFattura = cntFatture;
        }

        public static void visualizza()
        {
            MessageBox.Show("Numero fatture create: " + cntFatture);
            //MessageBox.Show("Numero fattura corrente: " + this.nFattura);
        }
    }
}
