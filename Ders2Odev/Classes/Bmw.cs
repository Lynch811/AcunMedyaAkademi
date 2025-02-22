using Ders2Odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2Odev.Classes
{
	public class Bmw : Araba, IEkranYazdır
	{
		public void EkranYaz(string marka, string model, string motorTipi, int vitesTuru)
		{
			Console.WriteLine("Marka: " + marka);
			Console.WriteLine("Model: " + model);
			Console.WriteLine("Motor Tipi: " + motorTipi);
			if (vitesTuru == 0)
			{
				Console.WriteLine("Vites Türü: " + "Düz Vites");
			}
			if (vitesTuru == 1)
			{
				Console.WriteLine("Vites Türü: " + "Otomatik Vites");
			}
			Console.WriteLine("*****************************************************");
		}
	}
}
