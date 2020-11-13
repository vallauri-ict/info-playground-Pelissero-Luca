using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Descrizione:
 * Realizzare una classe singleton che rappresenti una coda di stampa.
 * Dal programma sarà possibile inserire, tramite campo editabile, delle stringhe all'interno della coda di stampa. 
 * Un altro pulsante permetterà di stampare il primo elemento disponibile all'interno della coda. 
 * La stampa verrà simulata con l'apertura di una mbox. 
*/

namespace _008_Singleton_Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtPush.Text != "")
            {
                clsSingleton s = clsSingleton.GetClsSingleton();
                s.add(txtPush.Text);
            }
            else
            {
                MessageBox.Show("txt vuoto");
            }
        }

        private void btnStampa_Click_1(object sender, EventArgs e)
        {
            clsSingleton s = clsSingleton.GetClsSingleton();
            s.stampa();
        }
    }
}
