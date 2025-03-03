using Ders3.Classes;
using Ders3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3.Classes
{
	public class AkilliCocuk : Cocuk, IAskereGit,IEhliyetAl,IKlubeGit
	{
		public void askeregit(string isim)
		{
			Console.WriteLine(isim+"askere gidiyor..");
		}

		public void ehliyetal(string isim)
		{
			Console.WriteLine(isim + "ehliyet alıyor..");
		}

		public void klubegit(string isim)
		{
			Console.WriteLine(isim + "klube gidiyor..");
		}
	}
}
