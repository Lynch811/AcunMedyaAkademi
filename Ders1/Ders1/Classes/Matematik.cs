using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaDers1.Classes
{
	public class Matematik
	{
		//2 tane int tipinde parametre alan ve geriye
		//int tipinde değer dönen adı topla olan bir method

		public int Topla(int sayi1, int sayi2)
		{
			int sonuc = 0;
			sonuc = sayi1 + sayi2;
			// bu methodu kim nerde çağııryorsa ona ilgili değeri geriye dön
			return sonuc;
		}

		public int cikar(int sayi1, int sayi2)
		{
			return sayi1 - sayi2;
		}
		public int carp(int sayi1, int sayi2)
		{
			return sayi1 * sayi2;
		}
		public int bol(int sayi1, int sayi2)
		{
			return sayi1 / sayi2;	
		}



	}
}
