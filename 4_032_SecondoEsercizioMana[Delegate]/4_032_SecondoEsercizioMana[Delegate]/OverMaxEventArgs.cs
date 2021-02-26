using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_032_SecondoEsercizioMana_Delegate_
{
    class OverMaxEventArgs : EventArgs
    {
        public int ValoreSoglia { get; }

        public OverMaxEventArgs(int veroSoglia)
        {
            ValoreSoglia = ValoreSoglia;
        }
    }
}
