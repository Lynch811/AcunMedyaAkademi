using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4.Classes
{
	public class Araba
	{
		public int arabaYasHesapla(int arabayasi)
		{
			int sonuc = 0;
			sonuc = DateTime.Now.Year - arabayasi;
			return sonuc;
		}
	}
}
