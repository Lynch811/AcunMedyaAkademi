﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3.Abstracts
{
	//abstract class ların nesnesi oluşturulamaz
	//bu abstract class tan türeyen tüm classlar abstract ile başlayan metodları implement(uygulamak) zorundadırlar
	public abstract class Calisan
	{
		public abstract double maasinizNedir();

		public void mesaiyeBasla(string isim)
		{
			Console.WriteLine(isim + " mesaiye başladı");
		}
	}
}
