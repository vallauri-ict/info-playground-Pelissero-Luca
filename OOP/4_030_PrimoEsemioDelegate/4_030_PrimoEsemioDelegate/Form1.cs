using System;
using System.Windows.Forms;

namespace _4_030_PrimoEsemioDelegate
{
    //Dichiarazione del delegate che accetta 2 parametri interi
    //e restituisce un valore intero
    public delegate int Operazione(int a, int b);


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //dichiaro le 3 funzioni che utilizzerò con il delegate
        public int Somma(int x, int y)
        {
            return x + y;
        }

        public int Sottrazione(int x, int y)
        {
            return x - y;
        }

        public int Prodotto(int x, int y)
        {
            return x * y;
        }

        public int dif(int a, int b, Operazione op)
        {
            if (a >= b)
            {
                return op(a, b);
            }
            else
                return op(b, a);
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            // PRIMO METODO per usare un delegate
            // Instanzio il delegate e come parametro passo il nome della funzione
            Operazione op = new Operazione(Somma);  // Somma è la "funzione" puntata dal delegate

            // Richiamo il delegato che eseguirà la funzione somma
            MessageBox.Show("Somma = " + op(10, 15));
        }

        private void btnProdotto_Click(object sender, EventArgs e)
        {
            //SECONDO METODO Instazio il delegato
            Operazione op = Prodotto;

            // Richiamo
            MessageBox.Show("Prodotto = " + op(10, 15));
        }

        private void btnSottrazione_Click(object sender, EventArgs e)
        {
            //Operazione op = Sottrazione;

            //MessageBox.Show("Sottrazione= " + op(15, 10));

            //terzo metodo
            //instanzio il delegato
            Operazione op = Sottrazione;  //puntatore e sottrazione

            //richiamo dif passandogli con parametro il delegato
            MessageBox.Show("Differenza = " + dif(10, 12, op).ToString());
        }
    }
}
