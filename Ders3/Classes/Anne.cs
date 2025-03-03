using AcunMedyaDers1.Classes;
using Ders3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3.Classes
{
	//Anne class 1 Insan class ından türemiştir
	//Anne classı Insan classındaki public olan tüm değişken ve metodlara erişebilir T
	//aynı zamanda Iozellik interface inden de türemiştir.
	public class Anne:Insan,IOzellik,IOzellik2
	{
		public void dinle(string isim)
		{
			Console.WriteLine(isim+"dinliyorr");
		}

		//public void anneOkusun(string isim)
		//{
		//	Console.WriteLine(isim + " Okuyor...");
		//}

		public void Oku(string isim)
		{
			Console.WriteLine(isim + " Okuyor...");
		}

		public void yaz(string isim)
		{
			Console.WriteLine(isim+"yazıyorr");
		}
	}
}
