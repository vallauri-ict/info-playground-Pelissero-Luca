using System;
using System.Windows.Forms;

namespace _4_020_OOP_PersoneStudenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            btnRegistra.Enabled = false;

            Persona p = new Persona();
            p.setAttributs(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (txtVoti.Text == "")
                MessageBox.Show("Prima inserisci il dato");
            else
            {
                int voto = Convert.ToInt32(txtVoti.Text);
                Studente s = new Studente();
                s.aggiungiVoto(voto);
                btnMedia.Enabled = true;
                txtVoti.Text = "";
                txtVoti.Focus();
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            //double media = ;
            btnRegistra.Enabled = true;
            //MessageBox.Show("La media dello studente vale: " + media);
        }
    }
}
