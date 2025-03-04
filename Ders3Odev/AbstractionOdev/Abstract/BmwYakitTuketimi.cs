using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3Odev.AbstractionOdev.Abstract
{
	public class BmwYakitTuketimi : YakitTuketimi
	{
		public override double YakitTuketiminizNedir()
		{
			return 80.0;
		}
	}
}
