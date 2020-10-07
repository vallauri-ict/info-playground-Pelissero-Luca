using System;
using System.Windows.Forms;

namespace Multiform01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Form 2 da Design";
            f2.Show();

            Form2 f2b = new Form2(10);
            f2b.Text = "Form 2 da Design con parametro";
            f2b.Show();
        }

        private void btnApriF2b_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Aperta form dinamica";
            f2b.Show();
        }

        private void btnPassaTxt_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2(txtPassata);
            f2b.Text = "Form 2 passaggio di TextBox";
            f2b.Show();
        }

        private void btnFormModale_Click(object sender, EventArgs e)
        {
            FormModale fn = new FormModale();  // abbiamocreato una nuova form.

            // Gestisco il bottone cliccato.
            // dialog result ci restituisce il valore del bottone premuto.
            if (fn.ShowDialog() == DialogResult.OK)
            {
                txtEtaFm.Text = fn.eta;
                txtNomeFm.Text = fn.nome;
                MessageBox.Show("Premuto OK");
            }
            else
            {
                txtEtaFm.Text = "";
                txtNomeFm.Text = "";
                MessageBox.Show("Premuto ANNULLA");
            }
        }
    }
}
