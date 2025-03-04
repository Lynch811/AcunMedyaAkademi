using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ders3Odev.AbstractionOdev.Interfaces;
using Ders3Odev.AbstractionOdev.Classes;

namespace Ders3Odev.AbstractionOdev.Classes
{
	public class Porsche : Araba, IAracUcma
	{
		public void AracUcma(string Marka)
		{
			Console.WriteLine("** " + Marka + " Havada Uçar...");
		}
	}
}
