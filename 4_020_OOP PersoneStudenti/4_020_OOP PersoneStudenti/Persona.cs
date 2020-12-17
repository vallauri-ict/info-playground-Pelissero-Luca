using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_020_OOP_PersoneStudenti
{
    class Persona
    {
        private string nome, cognome, sesso;
        private int eta;

        public void setAttributs(string nome, string cognome, string sesso, int eta)
        {
            if (nome == "" || cognome == "" || sesso == "" || eta.ToString() == "")
            {
                MessageBox.Show("Dati mancanti");
            }
            else
            {
                Nome = nome;
                Cognome = cognome;
                Sesso = sesso;
                Eta = eta;
            }
        }

        public string Nome
        {
            get => this.nome;
            set => this.nome = value;
        }

        public string Cognome
        {
            get => this.cognome;
            set => this.cognome = value;
        }

        public string Sesso
        {
            get => this.sesso;
            set => this.sesso = value;
        }

        public int Eta
        {
            get => this.eta;
            set => this.eta = value;
        }
    }
}
