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
    public partial class Form2 : Form
    {
        public int n;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        private void btnValore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore = " + n);
        }
    }
}
