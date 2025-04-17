using Ders5.Classes;
using Ders5.Constructors;
using Ders5.Generic;
using System.Collections;

Insan i = new Insan("Hakan","yılmaz");
Console.WriteLine(i.adi+i.soyad);


Goz goz = new Goz("Kahverengi");
Kulak kulak = new Kulak("Kepçe");
Burun burun = new Burun("Kemer");
Kafa kafa = new Kafa(goz,kulak,burun);

YeniInsan yeni = new YeniInsan(kafa,"Talha","Arslan");
yeni.randevuKaydet();

//----------------------------- Ders 6 ------------------------------------------

ArrayList list = new ArrayList();
list.Add(12);
list.Add("asd");
list.Add(213.23);
list.Add(true);
list.Add(i);
list.Insert(2, "hakan");
list.Remove("hakan");
//for (int a = 0; a < list.Count; a++)
//{
	
//	int geriAlinanYas = (int)list[a];
//}

List<int> listSayilar = new List<int>();
listSayilar.Add(12);
listSayilar.Add(52);
listSayilar.Add(42);
listSayilar.Add(22);
foreach (int b in listSayilar)
{
	Console.WriteLine(b);
}
// n adında integer tipinde bir değişkenimiz değer tipli bir değişken
int n = 123;
//referans tipli bir değişkene dönüştürme
//boxing
object obj = n;

//unkoxing: referans tipli bir değişkeni değer tipli bir değişkene dönüştürme
n=(int)obj;


//------------------------------------------ Ders 7 ---------------------------------------

Person person = new Person();
person.ad = "Talha";
person.soyad = "Arslan";
person.save(person);

Animal animal = new Animal();
animal.nickName = "Maviş";
animal.save(animal);

GenericMethodOrnek genericMethod = new GenericMethodOrnek();
genericMethod.save(new Person { ad = "Ahmet", soyad = "Yılmaz" });
genericMethod.save(new Animal { nickName = "Köpüş:D"});
genericMethod.save(new Urun { UrunAdi = "Pc",UrunFiyat=123});
List<int> intNumbers = new List<int> { 1, 2, 3, 4, 5 };
List<double> doubleNumbers = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5 };
genericMethod.Yazdir(intNumbers);
genericMethod.Yazdir(doubleNumbers);
