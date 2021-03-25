using System;

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

        public Alunno(string nome, string cognome, string citta, string classe, string sezione, string spec)
            : base(nome, cognome, citta)
        {
            Classe = Convert.ToChar(classe);
            specializzazione = spec;
            Sezione = Convert.ToChar(sezione);
            progressivo++;
            matricola = "A" + progressivo.ToString().PadLeft(5, '0');
        }

        public override string visualizza()
        {
            return Matricola + " " + Nome + " " + Cognome + " " + Citta + " " + Classe + " " +
                Sezione + " " + Specializzazione;
        }
    }
}
