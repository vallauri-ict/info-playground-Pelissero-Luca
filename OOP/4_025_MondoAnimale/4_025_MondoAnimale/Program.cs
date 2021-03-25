using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _4_025_MondoAnimale
{
    public class Program
    {
		public static void Main(string[] args)
		{
			// AnimaleMarino p = new AnimaleMarino("x");
			// ERRATO: classe astratta!

			Cavallo c = new Cavallo("Furia del West");
			Uomo h = new Uomo("Johnny");
			Corvo w = new Corvo("Il corvo dell'uva");
			Tonno t = new Tonno("Palmera");
			Uccello u = new Uccello("Gabbiano");
			Pinguino p = new Pinguino("Jonny il biondo");

			c.mostra(); h.mostra();
			w.mostra(); t.mostra();
			u.mostra(); p.mostra();

			Console.ReadLine();
		}
	}
}
