using System;
using System.Windows.Forms;

namespace Es_9___Classe_Indexata
{
    public partial class Form1 : Form
    {
        MyIndexClass indexVect;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            indexVect = new MyIndexClass(Convert.ToInt32(txtElementi.Text));

            for (int i = 0; i < Convert.ToInt32(txtElementi.Text) - 1; i++)
            {
                indexVect[i] = i.ToString();
            }
            MessageBox.Show("Oggetto creato correttamente");
        }

        private void bntVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < indexVect.lenght(); i++)
            {
                s += indexVect[i] + " - ";
            }
            MessageBox.Show("Elementi: " + s);
        }
    }
}
