using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_023_ClasseAstratta
{
    class ElencoStudenti : Report
    {
        private List<Studente> lstStudenti = new List<Studente>();
        public string stampa = "";

        protected override void printBody()
        {
            foreach (var studente in lstStudenti)
            {
                stampa += studente.nomeCompleto() + "\n";
            }
        }

        protected override void printerFooter()
        {
            stampa += "FOOTER STAMPA STUDENTI\n";
        }

        protected override void printerHeader()
        {
            stampa += "INTESTAZIONE STAMPA STUDENTI\n";
        }

        public ElencoStudenti()
        {
            lstStudenti.Add(new Studente("Andrea", "Giccardi"));
            lstStudenti.Add(new Studente("Sergio", "Grosso"));
        }
    }
}
