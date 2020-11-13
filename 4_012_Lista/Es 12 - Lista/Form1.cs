using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Es_12___Lista
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public int ID;
            public string Titolo;
            public string Autore;
        }

        List<Libro> miaLista = new List<Libro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Libro l;

            l.ID = Convert.ToInt32(txtID.Text);
            l.Titolo = txtTitolo.Text;
            l.Autore = txtAutore.Text;

            miaLista.Add(l);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var elemento in miaLista)
                s += elemento.Titolo + "\n";
            MessageBox.Show(s);
        }
    }
}
