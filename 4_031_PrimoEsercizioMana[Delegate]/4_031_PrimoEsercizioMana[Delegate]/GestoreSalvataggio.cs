using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_031_PrimoEsercizioMana_Delegate_
{
    //dichiaro il mio delegato
    public delegate void salvataggioEseguitoEventHandler(int id);

    class GestoreSalvataggio
    {
        //Dichiaro l'evento
        public event salvataggioEseguitoEventHandler salvataggioEseguito;

        public void SalvaSuFile(int id)
        {
            MessageBox.Show("Sto eseguendo il salvataggio");

            salvataggioEseguito(id);
        }
    }
}
