using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiSimulaatio
{
	interface IHissi
	{
		int Minkerros { get; set; }
		int Maxkerros { get; set; }
		int Atkerros { get; set; }
	}
}
