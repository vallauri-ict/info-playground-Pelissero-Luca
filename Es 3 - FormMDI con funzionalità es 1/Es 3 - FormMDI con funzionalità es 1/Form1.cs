using System;
using System.Windows.Forms;

namespace Es_3___FormMDI_con_funzionalità_es_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            txtToolStripStatus.Text = "Premuto: " + toolStripDropDownButton1.Text;
        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Form 2 da Design";
            f2.Show();

            Form2 f2b = new Form2(5);
            f2b.Text = "Form 2 da Design con parametro";
            f2b.Show();

            txtToolStripStatus.Text = "Premuto: " + apriForm2ToolStripMenuItem.Text;
        }

        private void apriForm2bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2b f2b = new Form2b();
            f2b.Show();

            txtToolStripStatus.Text = "Premuto: " + apriForm2bToolStripMenuItem.Text;
        }

        private void passaTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTxt frm = new FormTxt(txtPassato);
            frm.Show();

            txtToolStripStatus.Text = "Premuto: " + passaTXTToolStripMenuItem.Text;
        }

        private void ModaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModale fM = new FormModale(txtNome, txtEta);
            fM.Show();

            txtToolStripStatus.Text = "Premuto: " + ModaleToolStripMenuItem.Text;
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
