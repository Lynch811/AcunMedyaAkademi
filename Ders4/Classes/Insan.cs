using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4.Classes
{
	public class Insan
	{
		public int yasHesapla(int dogumYili)
		{
			int sonuc = 0;
			sonuc= DateTime.Now.Year - dogumYili;
			return sonuc;
		}
	}
}
