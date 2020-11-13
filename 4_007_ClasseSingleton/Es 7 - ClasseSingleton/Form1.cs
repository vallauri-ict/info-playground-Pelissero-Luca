using System;
using System.Windows.Forms;

namespace Es_7___ClasseSingleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCraClasse_Click(object sender, EventArgs e)
        {
            EsSingleton s = EsSingleton.GetEsSingleton(Convert.ToInt32(txtValore.Text));
            MessageBox.Show("Valore = " + s.val);
            EsSingleton s1 = EsSingleton.GetEsSingleton(0);
            MessageBox.Show("Valore di s1: " + s1.val);
            MessageBox.Show("Valore di s: " + s.val);
        }
    }
}
