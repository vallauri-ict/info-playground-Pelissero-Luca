using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_020_OOP_PersoneStudenti
{
    class Studente : Persona
    {
        List<int> voti = new List<int>();

        public void aggiungiVoto(int voto)
        {
            voti.Add(voto);
        }

        public double media()
        {
            int count = voti.Count;
            int sommaVoti = 0;

            foreach (var item in voti)
            {
                sommaVoti += item;
            }

            voti.Clear();

            return (double)sommaVoti / count;
        }
    }
}
