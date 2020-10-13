using System;
using System.Windows.Forms;

namespace Es_3___FormMDI_con_funzionalità_es_1
{
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void btnFigliaDiChi_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
                MessageBox.Show("Sono figlia di: " + this.Owner.Text);
        }
    }
}
