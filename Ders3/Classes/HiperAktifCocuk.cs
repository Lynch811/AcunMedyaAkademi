using Ders3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3.Classes
{
	public class HiperAktifCocuk : Cocuk, IEhliyetAl
	{
		public void ehliyetal(string isim)
		{
			Console.WriteLine(isim + "ehliyet  alıyor..");
		}
	}
}
