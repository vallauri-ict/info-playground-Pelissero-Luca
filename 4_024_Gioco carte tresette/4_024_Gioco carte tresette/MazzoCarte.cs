using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_024_Gioco_carte_tresette
{
    class MazzoCarte
    {
        int prog;
        List<Carte> lstCarte = new List<Carte>();

        public MazzoCarte()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Carte carta = new Carte();
                    carta.Valore = carta.listaValori[j];
                    carta.Seme = carta.listaSemi[i];
                    lstCarte.Add(carta);
                }
            }
        }

        public void InserisciCarta(Carte carta)
        {
            if (!lstCarte.Exists(x => x.Seme == carta.Seme && x.Valore == carta.Valore))
            {
                lstCarte.Add(carta);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Carta già presente");
            }
        }

        public Carte DammiCarta(Carte carta = null)
        {
            if (carta != null)
            {
                int n = lstCarte.FindIndex(x => x.Seme == carta.Seme && x.Valore == carta.Valore);
                Carte aus = lstCarte[n];
                lstCarte.RemoveAt(n);
                return aus;
            }
            else
            {
                Carte aus = lstCarte[0];
                lstCarte.RemoveAt(0);
                return aus;
            }
        }

        public Carte proponi()
        {
            Random rnd = new Random();
            int n = rnd.Next(0, lstCarte.Count);
            Carte carta = lstCarte[n];
            lstCarte.RemoveAt(n);

            return carta;
        }

        public void mescola()
        {
            Random rnd = new Random();
            for (int i = 0; i < lstCarte.Count; i++)
            {
                int k = rnd.Next(0, i);
                Carte value = lstCarte[k];
                lstCarte[k] = lstCarte[i];
                lstCarte[i] = value;
            }
        }
    }
}
