using System;
using System.Windows.Forms;

namespace Pelissero_Luca
{
    public partial class FormFiglia1 : Form
    {
        public string pelle1;
        public string stoffa1;
        public string marchio1;

        public FormFiglia1()
        {
            InitializeComponent();
        }

        public FormFiglia1(string pelle, string stoffa, string marchio)
        {
            InitializeComponent();
            this.pelle1 = pelle;
            this.stoffa1 = stoffa;
            this.marchio1 = marchio;
        }

        private void chkPelle_CheckedChanged(object sender, EventArgs e)
        {
            pelle1 = "ok";
        }

        private void chkStoffa_CheckedChanged(object sender, EventArgs e)
        {
            stoffa1 = "ok";
        }

        private void cmbMarchi_SelectedIndexChanged(object sender, EventArgs e)
        {
            marchio1 = cmbMarchi.SelectedText.ToString();
        }
    }
}
