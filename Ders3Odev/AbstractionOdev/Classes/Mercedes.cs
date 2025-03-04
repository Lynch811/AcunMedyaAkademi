using Ders3Odev.AbstractionOdev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3Odev.AbstractionOdev.Classes
{
	public class Mercedes : Araba, IAracYuzme, IAracUcma
	{
		public void AracUcma(string Marka)
		{
			Console.WriteLine("** " + Marka + " Havada Uçar...");
		}

		public void AracYuzme(string Marka)
		{
			Console.WriteLine("** " + Marka + " Denizde Yüzer...");
		}
	}
}
