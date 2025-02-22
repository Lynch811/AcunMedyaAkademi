using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaDers1.Classes
{
	public class Insan
	{// bu başlangıç parantezinin adı başlangıç scope
	 //bir değişken tanımlarken 
	 //1- access modifiers(public,private,protected) 
	 //2- datatype(string,int,float,vs.)
	 //3- değişken adı(değişkene vermek istediğimiz ad);
		public string adi = "Hello";
		public string soyad;
		//tam sayısal verileri saklamamızı sağlar
		public int yas=21;
		//kesirli küsüratli sayıları saklamamızı sağlar
		public double maas = 21.5;
		//true yada false şeklinde verileri saklamamızı sağlar
		public bool cinsiyet=false;
		//methodlar 2  ye ayrılır geriye değer döndüren ve döndürmeyen
		//accessmodifiers dönüştipi  methodAdi(){}
		//geriye değer döndürmeyen adı uyu olan ve parametre almayan method
		public void Uyu()
		{
			Console.WriteLine("Uyuyorr...");
		}


		public void Uyuyo(string isim)
		{
			Console.WriteLine("Uyuyorr...");
		}
		public void AdSoyad(string isim,string soyad)
		{
			Console.WriteLine("Ad Soyad: "+isim + " " + soyad);
		}

	}//bu başlangıç parantezinin adı bitiş scope 
}
