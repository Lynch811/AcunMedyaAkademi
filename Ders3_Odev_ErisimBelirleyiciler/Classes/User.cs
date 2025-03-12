using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3_Odev_ErisimBelirleyiciler.Classes
{
	public class User
	{
		private string adSoyad;
		private int yas;
		public string Email;

		public void setAdSoyad(string _adSoyad)
		{
			adSoyad = _adSoyad;
		}
		public string getAdSoyad() 
		{
			return adSoyad;
		}
		public void setYas(int _yas)
		{
			yas = _yas;
		}
		public int getYas() 
		{
			return yas;
		}
		public void bilgileriGoster()
		{
			Console.WriteLine("AdSoyad: "+adSoyad+"/" +" Yaş: "+yas+"/"+"Email: " +Email);
		}
	}
}
