using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            string info = "";

            // USER
            Regex regUser = new Regex(@"^.{1,20}$");
            if (txtUser.Text == "")
            {
                MessageBox.Show("User Fiscale non inserito");
                valido = false;
                txtUser.BackColor = Color.Salmon;
            }
            else if (!regUser.IsMatch(txtUser.Text))
            {
                MessageBox.Show("User inserito non valido!");
                valido = false;
                txtUser.BackColor = Color.Salmon;
            }
            else
            {
                clsUtenti user = new clsUtenti();

                if (user.controllaUser(txtUser.Text) == true)
                {
                    user.user(txtUser.Text);
                    // COGNOME
                    Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$");
                    if (txtCognome.Text == "")
                    {
                        MessageBox.Show("Cognome non inserito");
                        valido = false;
                        txtCognome.BackColor = Color.Salmon;
                    }
                    else if (!regCognome.IsMatch(txtCognome.Text))
                    {
                        MessageBox.Show("Cognome inserito non valido!");
                        valido = false;
                        txtCognome.BackColor = Color.Salmon;
                    }
                    else
                    {
                        // Inserire nella classe utente
                        info = txtCognome.Text + "\t";
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
                        info += txtNome.Text + "\t";
                    }

                    // INDIRIZZO
                    Regex regIndirizzo = new Regex(@"^[A-Z][a-z]{2}\ [A-Z][a-z]*\ \d{1,2}$");
                    if (txtIndirizzo.Text == "")
                    {
                        MessageBox.Show("Indirizzo non inserito");
                        valido = false;
                        txtIndirizzo.BackColor = Color.Salmon;
                    }
                    else if (!regIndirizzo.IsMatch(txtIndirizzo.Text))
                    {
                        MessageBox.Show("Indirizzo inserito non valido!");
                        valido = false;
                        txtIndirizzo.BackColor = Color.Salmon;
                    }
                    else
                    {
                        // Inserire nella classe utente
                        info += txtIndirizzo.Text + "\t";
                    }

                    // CITTA'
                    Regex regCitta = new Regex(@"^[A-Z]{1}[a-z]+$");
                    if (txtCitta.Text == "")
                    {
                        MessageBox.Show("Città non inserita");
                        valido = false;
                        txtCitta.BackColor = Color.Salmon;
                    }
                    else if (!regCitta.IsMatch(txtCitta.Text))
                    {
                        MessageBox.Show("Città inserita non valida!");
                        valido = false;
                        txtCitta.BackColor = Color.Salmon;
                    }
                    else
                    {
                        // Inserire nella classe utente
                        info += txtCitta.Text + "\t";
                    }

                    // CAP 
                    Regex regCap = new Regex(@"^\d{5}$");
                    if (txtCap.Text == "")
                    {
                        MessageBox.Show("CAP non inserito");
                        valido = false;
                        txtCap.BackColor = Color.Salmon;
                    }
                    else if (!regCap.IsMatch(txtCap.Text))
                    {
                        MessageBox.Show("CAP inserito non valido!");
                        valido = false;
                        txtCap.BackColor = Color.Salmon;
                    }
                    else
                    {
                        // Inserire nella classe utente
                        info += txtCap.Text + "\t";
                    }

                    // MAIL
                    Regex regMail = new Regex(@"^.*(?<!\s)\@[a-zA-Z]{2,8}(?!\s)\.[a-zA-Z]{2,4}(?!\s)$");
                    if (txtMail.Text == "")
                    {
                        MessageBox.Show("Mail non inserita");
                        valido = false;
                        txtMail.BackColor = Color.Salmon;
                    }
                    else if (!regMail.IsMatch(txtMail.Text))
                    {
                        MessageBox.Show("Mail inserita non valida!");
                        valido = false;
                        txtMail.BackColor = Color.Salmon;
                    }
                    else
                    {
                        // Inserire nella classe utente
                        info += txtMail.Text + "\t";
                    }

                    // CODICE FISCALE
                    Regex regCodiceFiscale = new Regex(@"^[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]$");
                    if (txtCodiceFisc.Text == "")
                    {
                        MessageBox.Show("Codice Fiscale non inserito");
                        valido = false;
                        txtCodiceFisc.BackColor = Color.Salmon;
                    }
                    else if (!regCodiceFiscale.IsMatch(txtCodiceFisc.Text))
                    {
                        MessageBox.Show("Codice Fiscale inserito non valido!");
                        valido = false;
                        txtCodiceFisc.BackColor = Color.Salmon;
                    }
                    else
                    {
                        // Inserire nella classe utente
                        info += txtCodiceFisc.Text + "\t";
                    }

                    // PASSWORD
                    Regex regPassword = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$");
                    if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Password non inserita");
                        valido = false;
                        txtPassword.BackColor = Color.Salmon;
                    }
                    else if (!regPassword.IsMatch(txtPassword.Text))
                    {
                        MessageBox.Show("Password inserita non valida!");
                        valido = false;
                        txtPassword.BackColor = Color.Salmon;
                    }
                    else
                    {
                        // Inserire nella classe utente
                        info += txtPassword.Text + "\t";
                    }
                }
                else
                    MessageBox.Show("User già esistente");

                if (valido)
                {
                    StreamWriter sw = new StreamWriter("Utenti.txt", true);
                    sw.WriteLine(info);
                    sw.Close();
                    MessageBox.Show("Dati registrati correttamente");
                }
            }
        }
    }
}
