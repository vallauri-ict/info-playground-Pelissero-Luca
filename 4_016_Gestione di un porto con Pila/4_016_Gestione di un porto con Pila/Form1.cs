using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_016_Gestione_di_un_porto_con_Pila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Container
        {
            public string codice;
            public int peso;
            public int tara;
        }

        Stack<Container> conteiner = new Stack<Container>();

        private void btnPush_Click(object sender, EventArgs e)
        {
            if(txtCod.Text=="" || txtPeso.Text == "" || txtTara.Text == "")
                MessageBox.Show("Dati mancanti");
            else
            {
                Container c;
                c.codice = txtCod.Text;
                c.peso = Convert.ToInt32(txtPeso.Text);
                c.tara = Convert.ToInt32(txtTara.Text);
                conteiner.Push(c);
            }
            txtCod.Text = "";
            txtPeso.Text = "";
            txtTara.Text = "";
            MessageBox.Show("Dati inseriti correttamente");
        }

        private void bntPop_Click(object sender, EventArgs e)
        {
            if (conteiner.Count > 0)
            {
                Container p = conteiner.Peek();
                lblInfo.Text = "Info Container:\nCodice Container: " + p.codice + "\nPeso: " + p.peso + "\nTara: " + p.tara;
                conteiner.Pop();
            }
            else
                MessageBox.Show("Container da scaricare finiti");
        }
    }
}
