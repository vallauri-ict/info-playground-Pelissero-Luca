using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_032_SecondoEsercizioMana_Delegate_
{
    public delegate void OverMaxEventHandler(object sender, OverMaxEventArgs e);

    class Counter
    {
        public event OverMaxEventHandler OverMax;
        private int maxVal;
        public int cont = 0;

        public Counter(int n)
        {
            if (n > 10)
            {
                throw new ArgumentException("Il valore massimo è 10");
            }
            else
            {
                maxVal = n;
            }
        }

        public void Increment()
        {
            // incrementa un contatore
            cont++;
            if (cont>=maxVal)
            {
                OverMaxEventArgs e = new OverMaxEventArgs(cont);
                OnOverMax(this, e);
            }
        }

        private void OnOverMax(object sender, OverMaxEventArgs e)
        {
            if (OverMax != null) // se OverMax punta ad una funzione (se è tutto gestito da 
                                // qualcuno della nostra classe)
            {
                OverMax(sender, e);
            }
        }
    }
}
