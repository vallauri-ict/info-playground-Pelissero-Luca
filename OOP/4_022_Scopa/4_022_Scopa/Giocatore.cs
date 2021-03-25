using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_022_Scopa
{
    class Giocatore
    {
        private string nome;
        Mano mano;
        List<Mano> prese = new List<Mano>();

        public Giocatore(string n)
        {
            this.nome = n;
            mano = new Mano();
            prese.Clear();
        }

        public Mano Lettura()
        {
            return mano;
        }

        public List<Mano> Prese()
        {
            return prese;
        }

        public void Gioca(int i)
        {
            Carta giocata = mano.Gioca(i);
        }
    }
}
