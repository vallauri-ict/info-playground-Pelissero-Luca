using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_032_SecondoEsercizioMana_Delegate_
{
    public partial class Form1 : Form
    {
        private Counter cnt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                cnt = new Counter(Convert.ToInt32(txtMaxValue.Text));
                cnt.OverMax += new OverMaxEventHandler(gestioneMaxValue);
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }

        private void gestioneMaxValue(object sender, OverMaxEventArgs e)
        {
            MessageBox.Show("Raggiunto il valore: "+e.ValoreSoglia);
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            cnt.Increment();
        }
    }
}
