

using Loop_Condition_Odev.Classes;
//------------------------------------------------   1. Ödev   ------------------------------------------------
Person person = new Person();
Console.WriteLine("*************************************************************************");
Console.Write("Lütfen doğum yılınızı giriniz:");
int dogumyili = Convert.ToInt32(Console.ReadLine());
int gelendogumyili = person.yasHesapla(dogumyili);

if (gelendogumyili > 0 && gelendogumyili <= 18)
{
	Console.WriteLine("Yaşınız:" + gelendogumyili + " - Küçüksünüz");
}
else if (gelendogumyili > 18 && gelendogumyili <= 35)
{
	Console.WriteLine("Yaşınız:" + gelendogumyili + " - Gençsiniz");
}
else if (gelendogumyili > 35 && gelendogumyili <= 55)
{
	Console.WriteLine("Yaşınız:" + gelendogumyili + " - Yetişkinsiniz");
}
else if (gelendogumyili > 55 && gelendogumyili <= 75)
{
	Console.WriteLine("Yaşınız:" + gelendogumyili + " - Yaşlısınız");
}
else if (gelendogumyili > 75 && gelendogumyili <= 99)
{
	Console.WriteLine("Yaşınız:" + gelendogumyili + " - Çok yaşlısınız");
}
else
{
	Console.WriteLine("Yaşınız:" + gelendogumyili + " --- Ya hiç doğmadınız ya da çoktan öldünüz ---");
}
Console.WriteLine("*************************************************************************");

//------------------------------------------------   2. Ödev   ------------------------------------------------

Car car = new Car();
Console.Write("Lütfen aracınızın model yılını giriniz:");
int aracyasi = Convert.ToInt32(Console.ReadLine());
int gelenaracyasi = car.arabaYasHesapla(aracyasi);

if (gelenaracyasi > 0 && gelenaracyasi <= 10)
{
	Console.WriteLine("Arabanızın Yaşı:" + gelenaracyasi + " -Arabanız Yeni-");
}
else if (gelenaracyasi > 10 && gelenaracyasi <= 20)
{
	Console.WriteLine("Arabanızın Yaşı:" + gelenaracyasi + " -Servise götürmeniz gerekebilir-");
}
else if (gelenaracyasi > 20 && gelenaracyasi <= 30)
{
	Console.WriteLine("Arabanızın Yaşı:" + gelenaracyasi + " -Arabanız hurdaya çıkabilir-");
}
else
{
	Console.WriteLine("Arabanızın Yaşı:" + gelenaracyasi + " -Ya hiç üretilmedi ya da trafikten men edilmiştir-");
}
Console.WriteLine("*************************************************************************");
//------------------------------------------------   4. Ödev   ------------------------------------------------

List<(string Ad, string Soyad, string Meslek, double Maas, string Departman)> calisanListesi = 
	new List<(string, string, string, double, string)>
{
			("Ahmet", "Yılmaz", "Genel Müdür", 15000, "Yönetim"),
			("Mehmet", "Kaya", "Müdür", 10000, "Yönetim"),
			("Ayşe", "Demir", "Programcı", 8000, "IT"),
			("Ali", "Çelik", "Stajyer", 3000, "Staj")
};

Console.WriteLine("Çalışan Listesi");
Console.WriteLine("-----------------------------");
for (int i = 0; i < calisanListesi.Count; i++)
{
	var calisan = calisanListesi[i];
	Console.WriteLine("Ad:"+ calisan.Ad);
	Console.WriteLine("Soyad: "+ calisan.Soyad);
	Console.WriteLine("Meslek: "+ calisan.Meslek);
	Console.WriteLine("Maaş: "+ calisan.Maas);
	Console.WriteLine("Departman: "+ calisan.Departman);
	Console.WriteLine("-----------------------------");
}
double toplamMaas = 0;
foreach (var calisan in calisanListesi)
{
	toplamMaas += calisan.Maas;
}
Console.WriteLine("TOPLAM MAAŞ:"+ toplamMaas);
Console.WriteLine("*************************************************************************");

//------------------------------------------------   5. Ödev   ------------------------------------------------

List<(string Marka, string Model,  double YakitTuketimi)> aracListesi =
	new List<(string, string, double)>
{
			("Bmw", "M3", 4.3),
			("Porsche", "GT3RS", 12.2),
			("Ferrari", "LA FERRARİ", 8.9),
			("Audi", "RS6", 16),
};
Console.WriteLine("Araç Listesi");
Console.WriteLine("-----------------------------");
for (int i = 0; i < aracListesi.Count; i++)
{
	var arac = aracListesi[i];
	Console.WriteLine("Marka:" + arac.Marka);
	Console.WriteLine("Model: " + arac.Model);
	Console.WriteLine("Yakit Tüketimi: " + arac.YakitTuketimi);
	Console.WriteLine("-----------------------------");
}

double toplamYakitTuketimi = 0;
foreach (var arac in aracListesi)
{
	toplamYakitTuketimi += arac.YakitTuketimi;
}
Console.WriteLine("Toplam Yakıt Tüketimi:" + toplamYakitTuketimi);

Console.ReadKey();