using System;
using System.Collections.Generic;

namespace _4_022_Scopa
{
    class Mazzo
    {
        private List<Carta> mazzo = new List<Carta>();

        public Mazzo()
        {
            creaMazzo();
            mazzo = mescola(mazzo);
        }

        private void creaMazzo()
        {
            string[] seme = { "coppe", "denari", "bastoni", "spade" };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Carta carta = new Carta(i, seme[i]);
                    mazzo.Add(carta);
                }
            }
        }

        public List<Carta> mescola(List<Carta> list)
        {
            Random rnd = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int k = rnd.Next(0, i);
                Carta value = list[k];
                list[k] = list[i];
                list[i] = value;
            }
            return list;
        }

        public Carta Estrai(List<Carta> list)
        {
            Random rnd = new Random();
            int cont = rnd.Next(0, 41);
            Carta value = mazzo[cont];
            mazzo.RemoveAt(cont);

            return value;
        }
    }
}
