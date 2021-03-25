using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_022_Scopa
{
    class Mano
    {
        private List<Carta> mano = new List<Carta>();

        public Mano()
        {
            mano.Clear();
        }

        public List<Carta> Lettura()
        {
            return mano;
        }

        public Carta Gioca(int i)
        {
            Carta aus = mano[i];
            mano.RemoveAt(i);

            return aus;
        }
    }
}
