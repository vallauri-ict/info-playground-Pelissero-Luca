using System;

namespace _4_024_Gioco_carte_tresette
{
    class Carte
    {
        public string Valore { get; set; }
        public string Seme { get; set; }

        public string[] listaSemi = { "Cuore", "Picche", "Fiore", "Quadri" };
        public string[] listaValori = { "Asso", "2", "3", "4", "5", "6", "7", "Fante", "Regina", "Re" };

        public Carte(string valore, string seme)
        {
            Valore = valore;
            Seme = seme;
        }
    }
}
