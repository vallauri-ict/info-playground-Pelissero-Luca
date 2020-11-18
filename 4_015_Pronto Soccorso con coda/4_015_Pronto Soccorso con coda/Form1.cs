using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_015_Pronto_Soccorso_con_coda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Paziente
        {
            public string nome;
            public int eta;
            public string colore;
        }

        //code
        Queue<Paziente> rosso = new Queue<Paziente>();
        Queue<Paziente> giallo = new Queue<Paziente>();
        Queue<Paziente> verde = new Queue<Paziente>();
        Queue<Paziente> bianco = new Queue<Paziente>();

        //lista temperature
        List<int> temperature = new List<int>();

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtEta.Text == "" || txtColore.Text == "" || txtTemperatura.Text == "")
                MessageBox.Show("Dati mancanti");
            else
            {
                Paziente p;
                p.nome = txtNome.Text;
                p.eta = Convert.ToInt32(txtEta.Text);
                p.colore = txtColore.Text;

                temperature.Add(Convert.ToInt32(txtTemperatura.Text));

                switch (txtColore.Text)
                {
                    case "rosso":
                        rosso.Enqueue(p);
                        break;
                    case "giallo":
                        giallo.Enqueue(p);
                        break;
                    case "verde":
                        verde.Enqueue(p);
                        break;
                    case "bianco":
                        bianco.Enqueue(p);
                        break;
                }
            }

            MessageBox.Show("Paziente registrato correttamente");

            txtNome.Text = "";
            txtEta.Text = "";
            txtColore.Text = "";
            txtTemperatura.Text = "";
        }

        private void btnVisita_Click(object sender, EventArgs e)
        {
            Paziente p;

            if (rosso.Count > 0)
            {
                p = rosso.Peek();
                lblInfoPaziente.Text = "Info Paziente: \n - Nome: " + p.nome + "\n - Età: " + p.eta + "\n - Colore: " + p.colore;
                rosso.Dequeue();
            }
            else
            {
                if (giallo.Count > 0)
                {
                    p = giallo.Peek();
                    lblInfoPaziente.Text = "Info Paziente: \n - Nome: " + p.nome + "\n - Età: " + p.eta + "\n - Colore: " + p.colore;
                    giallo.Dequeue();
                }
                else if(verde.Count > 0)
                {
                    p = verde.Peek();
                    lblInfoPaziente.Text = "Info Paziente: \n - Nome: " + p.nome + "\n - Età: " + p.eta + "\n - Colore: " + p.colore;
                    verde.Dequeue();
                }
                else if (bianco.Count > 0)
                {
                    p = bianco.Peek();
                    lblInfoPaziente.Text = "Info Paziente: \n - Nome: " + p.nome + "\n - Età: " + p.eta + "\n - Colore: " + p.colore;
                    bianco.Dequeue();
                }
                else
                {
                    lblInfoPaziente.Text = "Info Paziente:";
                    txtNome.Text = "";
                    txtEta.Text = "";
                    txtColore.Text = "";
                    txtTemperatura.Text = "";
                    MessageBox.Show("Non ci sono paziente da visitare.");
                }
            }
        }

        private void bntAddTemp_Click(object sender, EventArgs e)
        {
            int Tmax = 0;
            int Tmin = 50;

            for (int i = 0; i < temperature.Count; i++)
            {
                if (temperature[i] > Tmax)
                    Tmax = temperature[i];
                if(temperature[i] < Tmin)
                    Tmin = temperature[i];
            }
            MessageBox.Show("Max temperature: " + Tmax + "\nMin temperature: " + Tmin);
        }
    }
}
