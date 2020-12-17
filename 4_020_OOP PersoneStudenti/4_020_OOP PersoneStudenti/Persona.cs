﻿using System;
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
                this.nome = nome;
                this.cognome = cognome;
                this.sesso = sesso;
                this.eta = eta;
            }
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCognome()
        {
            return this.cognome;
        }

        public string getSesso()
        {
            return this.sesso;
        }

        public int getEta()
        {
            return this.eta;
        }
    }
}
