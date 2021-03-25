using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _018_OOP_PersoneStudenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Studente> lstStudenti = new List<Studente>();

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s.setAttributs(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtVoto.Text));
            lstStudenti.Add(s);
            listStudente.Items.Add(s.getCognome());
        }

        private void listStudente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string cognome = listStudente.SelectedItems[0].Text;

            foreach (Studente i in lstStudenti)
            {
                if (i.getCognome() == cognome)
                {
                    i.voti.Add(Convert.ToInt32(txtVoto.Text));
                    break;
                }
            }
        }

        private void btnInserisciVoto_Click(object sender, EventArgs e)
        {
            foreach (Studente i in lstStudenti)
            {
                if(i.getCognome() == listStudente.SelectedItems[0].Text)
                {
                    i.voti.Add(Convert.ToInt32(txtVoto.Text));
                }
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s = lstStudenti.Find(stud => stud.getCognome() == listStudente.SelectedItems[0].Text);
            MessageBox.Show("Lo studente " + s.getCognome() + " " + s.getNome() + " ha " + s.getEta() + " anni e la sua media vale " + s.media());
        }
    }
}
