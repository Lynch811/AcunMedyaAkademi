using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Condition_Odev.Classes
{
	public class Car
	{
		public int arabaYasHesapla(int arabayasi)
		{
			int sonuc = 0;
			sonuc = DateTime.Now.Year - arabayasi;
			return sonuc;
		}
	}
}
