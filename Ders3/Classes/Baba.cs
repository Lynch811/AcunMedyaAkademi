using AcunMedyaDers1.Classes;
using Ders3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3.Classes
{
	public class Baba:Insan,IOzellik
	{
		//public void babaOkusun(string isim)
		//{
		//	Console.WriteLine(isim + " Okuyor...");
		//}

		public void Oku(string isim)
		{
			Console.WriteLine(isim + " Okuyor...");
		}
	}
}
