using AcunMedyaDers1.Classes;


//Console.WriteLine("Hello, World!");


//bir classtan nesne oluşturma
//ClassIsmi  nesneAdi =new ClassIsmı();


Insan İ = new Insan();
İ.adi = "Talha";
İ.soyad = "Arslan";
İ.yas = 46;
İ.maas = 3.14;
İ.cinsiyet = false;
//uyu metodunu çağıralım
İ.Uyu();







Araba arb = new Araba();
arb.Marka = "Porsche";
arb.Model = "911 GT3RS";
arb.yıl = 2024;
arb.durumu = true;
arb.Araba1(arb.Marka, arb.Model);



Matematik m = new Matematik();
//1.yöntem 
int gelendeger = m.Topla(5, 7);
Console.WriteLine("Topla: " + gelendeger);


//2.yöntem 

Console.WriteLine("Toplam: " + m.Topla(5, 3));
Console.WriteLine("Çıkartma : " + m.cikar(5, 3));
Console.WriteLine("Çarpma : " + m.carp(5, 3));
Console.WriteLine("Bölme : " + m.bol(6, 3));




Console.ReadKey();