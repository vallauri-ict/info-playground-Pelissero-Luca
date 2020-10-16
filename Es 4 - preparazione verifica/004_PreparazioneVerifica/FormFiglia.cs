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
    public partial class FormFiglia : Form
    {
        private TextBox tp;
        public TextBox txtF1;
        public FormFiglia()
        {
            InitializeComponent();
        }

        public FormFiglia(TextBox txtPadre)
        {
            InitializeComponent();
            this.tp = txtPadre;
            this.txtF1 = txtInviaAFormPadre;
        }

        private void FormFiglia_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInviaFormPadre_Click(object sender, EventArgs e)
        {
            tp.Text = txtInviaAFormPadre.Text;
        }
    }
}
