

// Array => 1.aynı türden verileri bir isim latında tutmamızı sağlar
// hangiturdeveri[] diziAdi=new hangiturdeveri[7];
//dizilerin ilk elemanı sıfırdan başlar
using Ders4.Classes;

string[] gunler = new string[7];

gunler[0] = "Pazartesi";
gunler[1] = "Salı";
gunler[2] = "Çarşamba";
gunler[3] = "Perşembe";
gunler[4] = "Cuma";
gunler[5] = "Cumartesi";
gunler[6] = "Pazar";

//for düngüsü ile dizi yazma
for (int i = 0; i < gunler.Length; i++)
{
	Console.WriteLine(gunler[i]);
}
Console.WriteLine("**********************************************");

//if(koşul){yapılması gereken neyse o yapılır} else{yapılması gereken neyse o yapılır}
//else if{yapılcak işlem yapılır}
int yas = 27;
if (yas > 0 && yas <=18)
{
	Console.WriteLine("Küçüksünüz büyüde gel :D");
}
else if(yas >18 && yas<35){
	Console.WriteLine("Gençsiniz :D");
}
else
{
	Console.WriteLine("giri yapamassınız!!");
}
Console.WriteLine("**********************************************");
//1980

//int dogumyili = 1980;
//int hesap;
//int Bulundugumuzyıl = DateTime.Now.Year;
//hesap = Bulundugumuzyıl - dogumyili;
//Console.WriteLine("Yaşınız:"+hesap);
//if (hesap == 0 || hesap<=18 )
//{
//	Console.WriteLine("Yaşınız:"+hesap+" Biraz büyüyün :D");
//}
//else if (hesap>18 ||hesap<=40)
//{
//	Console.WriteLine("Yaşınız:"+hesap+" Orta Yaşlısınız");
//}
//else
//{
//	Console.WriteLine("Yaşınız:" + hesap + " Yaşlısınız");
//}

Insan ınsan = new Insan();
int gelenyas = ınsan.yasHesapla(1900);
Console.WriteLine("Yaşınız: "+gelenyas);
if (gelenyas > 0 && gelenyas <= 18)
{
	Console.WriteLine("Yaşınız:" + gelenyas + " -küçüksünüz");
}
else if (gelenyas > 18 && gelenyas <= 35)
{
	Console.WriteLine("Yaşınız:" + gelenyas + " -gençsiniz");
}
else if (gelenyas > 35 && gelenyas <= 55)
{
	Console.WriteLine("Yaşınız:" + gelenyas + " -yetişkinsiniz");
}
else if (gelenyas > 55 && gelenyas <= 75)
{
	Console.WriteLine("Yaşınız:" + gelenyas + " -yaşlısınız");
}
else if (gelenyas > 75 && gelenyas <= 99)
{
	Console.WriteLine("Yaşınız:" + gelenyas + " -çok yaşlısınız");
}
else
{
	Console.WriteLine("Birader öldünmü kaldınmı ne bilek biz :P ");

}
Console.WriteLine("**********************************************");

Araba araba = new Araba();
int gelenArabaYasi = araba.arabaYasHesapla(1800);
Console.WriteLine("Arabanızın Yaşı: " + gelenArabaYasi);
if (gelenArabaYasi > 0 && gelenArabaYasi <= 10)
{
	Console.WriteLine("Arabanızın Yaşı:" + gelenArabaYasi + " -Arabanız yeni");
}
else if (gelenArabaYasi > 10 && gelenArabaYasi <= 20)
{
	Console.WriteLine("Arabanızın Yaşı::" + gelenArabaYasi + " -Servise bir baktırın");
}
else if (gelenArabaYasi > 20 && gelenArabaYasi <= 30)
{
	Console.WriteLine("Arabanızın Yaşı::" + gelenArabaYasi + " -Arabanız hurdaya çıkabilir :d");
}
else
{
	Console.WriteLine("Arabanız ya hiç üretilmedi yada trafikten men edilmiş sorryyy :d :d");
}
//for/int sayac=0; sayac<10; sayac++){ yapılması gereken işlem}
Console.WriteLine("**********************************************");
for (int i = 0; i < 10; i++)
{
	Console.WriteLine("Merhaba dünya:"+i);
}
Console.WriteLine("**********************************************");
//dizinin 2.farklı tanımı
//n elemanlı bir dizi tanımlamak için
//hangiturdeveri[] diziadi=new{}
int[] sayilar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 123, 1234, 23 };
int sayiToplam = 0;
for (int i = 0; i < sayilar.Length; i++)
{
	sayiToplam = sayiToplam + sayilar[i];
	Console.WriteLine(sayilar[i]);
}
Console.WriteLine("Sayıların Toplamı: "+sayiToplam);

//içine çalışan tipinde veri alan bir dizi
Calisan[] calisanlar = { };