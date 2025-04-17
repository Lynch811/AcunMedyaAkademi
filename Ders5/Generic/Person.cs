using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5.Generic
{
	public class Person
	{
		public string ad;
		public string soyad;

		public override string ToString()
		{
			return "Person [ad=" + ad + " soyad="+soyad+"]";
			// return $"ad : soyad: {ad}{soyad}";
		}
		//Person p = new Person();
		//p.ToString();

		public void save(Person p)
		{
			Console.WriteLine(p.ToString() + " kaydedildi");

		}
	}
}
