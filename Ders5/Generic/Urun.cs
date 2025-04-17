using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5.Generic
{
	public class Urun
	{
		public string UrunAdi;
		public decimal UrunFiyat;
		public override string ToString()
		{
			return "Person [UrunAd=" + UrunAdi + " Fiyat=" + UrunFiyat + "]";
		}
		public void save(Urun u)
		{
			Console.WriteLine(u.ToString() + " kaydedildi");

		}
	}
}
