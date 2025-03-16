using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5.Constructors
{
	public class YeniInsan
	{
		public Kafa kafa;
		public string isim;
		public string soyisim;

		public YeniInsan(Kafa kafa,string isim,string soyisim)
		{
			this.kafa = kafa;
			this.isim = isim;	
			this.soyisim = soyisim;
		}

		public void randevuKaydet()
		{
			Console.WriteLine("Randevu alan kişinin adı:"+isim+" "+
				"Soyadı:"+soyisim+ " " +
				"Göz Rengi:" +kafa.goz.renk+ " " +
				"Burnu:" +kafa.burun.tip+ " " +
				"Kulak:" +kafa.kulak.sekil
				);
		}
	}
}
