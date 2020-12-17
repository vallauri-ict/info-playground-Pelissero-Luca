using System;
using System.Windows.Forms;

namespace _4_020_OOP_PersoneStudenti
{
    public partial class Form1 : Form
    {
        Studente s;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            btnRegistra.Enabled = false;
            btnMedia.Enabled = false;

            s = new Studente();
            s.setAttributs(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));

            btnAggiungi.Enabled = true;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (txtVoti.Text == "")
                MessageBox.Show("Inserisci il dato");
            else
            {
                s.aggiungiVoto(Convert.ToInt32(txtVoti.Text));
                btnMedia.Enabled = true;
                txtVoti.Text = "";
                txtVoti.Focus();
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.media().ToString());

            btnAggiungi.Enabled = false;
            btnRegistra.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAggiungi.Enabled = false;
            btnMedia.Enabled = false;
        }
    }
}
