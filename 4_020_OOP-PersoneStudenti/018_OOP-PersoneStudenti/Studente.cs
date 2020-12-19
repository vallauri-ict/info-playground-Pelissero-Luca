using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_OOP_PersoneStudenti
{
    class Studente : Persona
    {
        public List<int> voti = new List<int>();

        public double media()
        {
            int sommaVoti = 0;
            foreach (var item in voti)
            {
                sommaVoti += item;
            }

            return (double)sommaVoti / voti.Count;
        }
    }
}
