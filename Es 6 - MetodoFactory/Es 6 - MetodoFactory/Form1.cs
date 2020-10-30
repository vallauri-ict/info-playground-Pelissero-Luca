using System;
using System.Windows.Forms;

namespace Es_6___MetodoFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaQuadrato_Click(object sender, EventArgs e)
        {
            Quadrato q;

            if (txtLatoQuadrato.Text != "")
            {
                try
                {
                    q = Quadrato.creaQuadrato(Convert.ToInt32(txtLatoQuadrato.Text));

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Compilare il campo");
            }
        }
    }
}
