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
    public partial class Form2b : Form
    {
        public Form2b()
        {
            InitializeComponent();
        }

        private void btnApriFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia fF = new FormFiglia();
            this.AddOwnedForm(fF);
            fF.Show();
        }
    }
}
