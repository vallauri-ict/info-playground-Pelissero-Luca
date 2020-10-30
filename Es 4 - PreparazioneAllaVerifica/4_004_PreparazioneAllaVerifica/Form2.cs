using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_004_PreparazioneAllaVerifica
{
    public partial class Form2 : Form
    {
        public string nome;
        public string eta;
        private TextBox txt1;
        private TextBox txt2;
        public Form2(TextBox txtNome, TextBox txtEta)
        {
            InitializeComponent();
            this.txt1 = txtNome;
            this.txt2 = txtEta;
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            eta = txtEta.Text;
            //MessageBox.Show("Nome:" + nome+"\nEtà:"+eta);
            /*txt1.Text = nome;
            txt2.Text = eta;*/
            Close();
        }

    }
}
