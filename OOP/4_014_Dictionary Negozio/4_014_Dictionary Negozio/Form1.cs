using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_014_Dictionary_Negozio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Dizionario
        {
            public int key;
            public string articolo;
        }

        Dictionary<int, Dizionario> diz = new Dictionary<int, Dizionario>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dizionario d;

            d.key = Convert.ToInt32(txtKey.Text);
            d.articolo = txtValue.Text;
            diz.Add(Convert.ToInt32(txtKey.Text), d);

            //MessageBox.Show("Dati inseriti correttamente");
        }

        private void btnVis_Click(object sender, EventArgs e)
        {
            lblNArt.Text = "Numero articoli = " + diz.Count;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            lblRicerca.Text = "Articolo ricercato = " + diz[Convert.ToInt32(txtKey.Text)].articolo;
        }
    }
}
