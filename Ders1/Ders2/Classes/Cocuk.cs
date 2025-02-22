using AcunMedyaDers1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1.Classes
{
	public class Cocuk:Insan
	{
		public string sifat;
		public void adSoyadSifatYaz(string isim,string soyad ,string sifati)
		{
			Console.WriteLine(isim + " " + soyad + " " + sifati);
		}
	}
}
