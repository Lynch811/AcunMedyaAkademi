using AcunMedyaDers1.Classes;
using Ders3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3.Classes
{
	public class Bmw : Araba, IAracHizi,IAracGittigiYol,IAracHavaYolu
	{
		public void aracgittigiyol(string isim)
		{
			Console.WriteLine("**" + isim + " Denizde yüzüyor..");
		}

		public void arachızlıgidiyor(string isim)
		{
			Console.WriteLine("**"+isim+" Çok hızlı gidiyor..");
		}

		public void havadauc(string isim)
		{
			Console.WriteLine("**" + isim + " Havada uçuyor..");
		}
	}
}
