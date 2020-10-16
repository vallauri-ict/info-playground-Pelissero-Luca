using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_PreparazioneVerifica
{
    public partial class FormSecondaria : Form
    {
        private TextBox n;
        private TextBox e;

        public FormSecondaria()
        {
            InitializeComponent();
        }

        public FormSecondaria(TextBox txtNome, TextBox txtEta)
        {
            InitializeComponent();
            this.n = txtNome;
            this.e = txtEta;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            n.Text = txtNome.Text;
            this.e.Text = txtEta.Text;
            MessageBox.Show("Nome: " + txtNome.Text + "  Età: " + txtEta.Text);
            Close();
        }

        private void FormSecondaria_Load(object sender, EventArgs e)
        {

        }
    }
}
