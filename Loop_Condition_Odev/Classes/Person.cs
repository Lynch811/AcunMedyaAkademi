using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Condition_Odev.Classes
{
	public class Person
	{
		public int yasHesapla(int dogumYili)
		{
			int sonuc = 0;
			sonuc = DateTime.Now.Year - dogumYili;
			return sonuc;
		}
	}
}
