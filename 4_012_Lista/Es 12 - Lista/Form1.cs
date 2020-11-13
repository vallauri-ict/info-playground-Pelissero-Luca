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
        List<Libro> lstLibri = new List<Libro>();

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

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Libro lib;

            lib.Autore = txtAutore.Text;
            lib.Titolo = txtTitolo.Text;
            lib.ID = Convert.ToInt32(txtID.Text);

            lstLibri.Add(lib);
        }

        private void btnVis_Click(object sender, EventArgs e)
        {
            string l = "";
            foreach (var item in lstLibri)
                l += item.Titolo + "\n";
            MessageBox.Show(l);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Libro l = lstLibri.Find(lib => lib.Titolo == txtTitoloAutore.Text);
            MessageBox.Show(l.Autore);
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            List<Libro> aus = new List<Libro>();
            aus = lstLibri.FindAll(aut => aut.Autore == txtTitoloAutore.Text);

            string l = "";
            foreach (var item in aus)
                l += item.Titolo + "\n";
            MessageBox.Show(l);
        }
    }
}
