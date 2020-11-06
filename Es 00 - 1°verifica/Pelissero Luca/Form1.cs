using System;
using System.Windows.Forms;

namespace Pelissero_Luca
{
    public partial class Form1 : Form
    {
        public string pelle;
        public string stoffa;
        public string marchio;

        public Form1()
        {
            InitializeComponent();
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiglia1 f = new FormFiglia1(pelle, stoffa, marchio);
            this.AddOwnedForm(f);
            f.MdiParent = this;
            f.Show();
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((pelle == null || stoffa == null) && marchio == null)
            {
                ModalScelte m = new ModalScelte();
                if (m.ShowDialog() == DialogResult.OK)
                    m.Close();
            }
            else
            {
                FormFiglia2 f = new FormFiglia2(pelle, stoffa, marchio);
                this.AddOwnedForm(f);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.Text = "Uscire";
            if (f.ShowDialog() == DialogResult.OK)
            {
                f.Close();
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo f = new FormInfo();
            if (f.ShowDialog() == DialogResult.OK)
            {
                f.Close();
            }
        }
    }
}
