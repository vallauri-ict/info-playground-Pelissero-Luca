using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_026_Stagisti
{
    class Alunno : Persona
    {
        #region attributi

        protected static int progressivo = 0;
        private readonly string matricola;
        private char classe;
        private char sezione;
        private string specializzazione;

        #endregion

        public char Classe
        {
            get => classe;
            set => classe = Convert.ToChar(value);
        }

        public string Matricola => matricola;

        public char Sezione
        {
            get => sezione;
            set => sezione = Convert.ToChar(value);
        }

        public string Specializzazione
        {
            get => specializzazione;
            set => specializzazione = value;
        }

        public Alunno(string nome, string cognome, string citta) : base(nome, cognome, citta)
        {
        }

        public override string visualizza()
        {
            throw new NotImplementedException();
        }
    }
}
