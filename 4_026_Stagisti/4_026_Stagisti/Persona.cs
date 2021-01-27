using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_026_Stagisti
{
    abstract class Persona
    {
        #region attributi
        private string nome;
        private string cognome;
        private string citta;
        #endregion

        public string Citta
        {
            get => citta;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    citta = value;
                }
                else
                {
                    throw new Exception("Città non valida");
                }
            }
        }

        public string Cognome
        {
            get => cognome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    cognome = value;
                }
                else
                {
                    throw new Exception("Cognome non valido");
                }
            }
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Nome non valido");
                }
            }
        }

        protected Persona(string nome, string cognome, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Citta = citta;
        }

        public abstract string visualizza();
    }
}
