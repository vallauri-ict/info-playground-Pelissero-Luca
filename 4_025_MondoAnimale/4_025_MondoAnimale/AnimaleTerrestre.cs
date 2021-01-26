using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_025_MondoAnimale
{
    public abstract class AnimaleTerrestre : Animale
    {
		public AnimaleTerrestre(string s) : base(s)
		{
		}

		public override string vive()
		{
			return "sulla terraferma";
		}

		public override string chi_sei()
		{
			return "un animale terrestre";
		}
	}
}
