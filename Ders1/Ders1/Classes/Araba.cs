using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaDers1.Classes
{
	public class Araba
	{
		public string Marka;
		public string Model;
		public int yıl;
		public bool durumu;
		public void Araba1(string marka,string model)
		{
			Console.WriteLine(marka +" " + model + " " + "Tam gaz devam..");
		}

		public void EkranYaz(string arabamarka,string arabamodel)
		{
			Console.WriteLine(arabamarka +" "+ arabamodel);
		}
	}
}
