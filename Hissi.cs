using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiSimulaatio
{
	class Hissi : IHissi
	{
		static int SIIRTYMAODOTUS = 250;
		public int Minkerros { get; set; }
		public int Maxkerros { get; set; }
		public int Atkerros { get; set; }

		public Hissi(int min, int max, int at)
		{
			Minkerros = min;
			Maxkerros = max;
			Atkerros = at;
		}
	}
}
