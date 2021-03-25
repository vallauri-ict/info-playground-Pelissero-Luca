using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_013_Dictionary
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public string Titolo;
            public string Autore;
        }
        public int i = 0;
        Dictionary<int, Libro> libreria = new Dictionary<int, Libro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Libro l;
            l.Titolo = txtTitolo.Text;
            l.Autore = txtAutore.Text;
            libreria.Add(i, l);
            i++;
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach (var key in libreria.Keys)
                MessageBox.Show("Chiave: " + Convert.ToString(key));

            foreach (var item in libreria.Values)
                MessageBox.Show("Autore: " + item.Autore + "\nTitolo: " + item.Titolo);
        }
    }
}
