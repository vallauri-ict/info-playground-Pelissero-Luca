using System;
using System.Windows.Forms;

namespace _4_026_Stagisti
{
    public partial class Form1 : Form
    {
        Elenco elencoStudenti;
        Stagista stu;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elencoStudenti = new Elenco();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Alunno stu;

            if (txtOre.Text.Trim() == "")
            {
                stu = new Alunno(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(),
                    cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString());
            }
            else
            {
                stu = new Stagista(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(),
                    cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString(), cmbAzienda.SelectedItem.ToString(), txtOre.Text);

                btnRicerca.Enabled = true;
            }
            elencoStudenti.inserisci(stu);
            elencoStudenti.VisualizzaDgv(dgvStudenti);
            pulisciCampi();
        }

        private void pulisciCampi()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";

                    // stesse cose:
                    //TextBox txt = (TextBox)t;
                    //txtCitta.Text = "";
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string azienda = cmbAzienda.SelectedIndex.ToString();
            int ore = elencoStudenti.oreAzienda(azienda);

            if (ore != 0)
            {
                MessageBox.Show("Gli stagisti hanno effettuiato " + ore + " ore in " + azienda,
                    "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Non è stata effettuata alcuna ora in " + azienda,
                    "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
