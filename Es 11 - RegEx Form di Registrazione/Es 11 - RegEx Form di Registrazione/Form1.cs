using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_11___RegEx_Form_di_Registrazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            // che metto a false se una dele rgx non è rispettata
            bool valido = true;

            // COGNOME
            Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (txtCognome.Text == "")
            {
                MessageBox.Show("Cognome non inserito");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            else if(!regCognome.IsMatch(txtCognome.Text))
            {
                MessageBox.Show("Cognome inserito non valido!");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            else
            {
                // Inserire nella classe utente
            }

            // NOME
            Regex regNome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome non inserito");
                valido = false;
                txtNome.BackColor = Color.Salmon;
            }
            else if (!regNome.IsMatch(txtNome.Text))
            {
                MessageBox.Show("Nome inserito non valido!");
                valido = false;
                txtNome.BackColor = Color.Salmon;
            }
            else
            {
                // Inserire nella classe utente
            }

            // GLI ALTRI CAMPI

            // CAP (5 numeri)

            /* MAIL 
             inizia con: dei caratteri, '.', '_', '-'
             poi '@'
             poi alcuni caratteri
             poi '.'
             poi da 2 a 4 caratteri
            */

            /* PASSWORD
             da 8 a 20 caratteri
             ^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$
            */
        }
    }
}
