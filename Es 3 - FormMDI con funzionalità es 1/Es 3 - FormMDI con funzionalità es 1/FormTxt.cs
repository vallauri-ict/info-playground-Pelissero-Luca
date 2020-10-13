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
    public partial class FormTxt : Form
    {
        private TextBox txtAus;

        public FormTxt()
        {
            InitializeComponent();
        }

        public FormTxt(TextBox txt)
        {
            InitializeComponent();
            this.txtAus = txt;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtAus.Text = txtValore.Text;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            txtAus.Text = "";
            Close();
        }
    }
}
