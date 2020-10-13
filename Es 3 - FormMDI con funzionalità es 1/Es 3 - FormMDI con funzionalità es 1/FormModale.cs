using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_3___FormMDI_con_funzionalità_es_1
{
    public partial class FormModale : Form
    {
        public string nome = "";
        public string eta = "";
        TextBox txtNome;
        TextBox txtEta;

        public FormModale()
        {
            InitializeComponent();
        }

        public FormModale(TextBox txtN, TextBox txtE)
        {
            InitializeComponent();
            this.txtNome = txtN;
            this.txtEta = txtE;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtNome.Text = txtNome2.Text;
            txtEta.Text = txtEta2.Text;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEta.Text = "";
            Close();
        }
    }
}
