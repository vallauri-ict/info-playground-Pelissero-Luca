using System;
using System.Windows.Forms;

namespace Multiform01
{
    public partial class FormModale : Form
    {
        public string nome = "";
        public string eta = "";

        public FormModale()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            eta = txtEta.Text;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            nome = "";
            eta = "";
        }
    }
}
