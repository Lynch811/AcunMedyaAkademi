using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3Odev.AbstractionOdev.Abstract
{
	public class PorscheYakitTuketimi : YakitTuketimi
	{
		public override double YakitTuketiminizNedir()
		{
			return 60.0;
		}
	}
}
