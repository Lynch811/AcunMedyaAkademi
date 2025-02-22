using AcunMedyaDers1.Classes;
using Ders1.Classes;
using Ders2.Classes;

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



//---------------------------- Ders 2 --------------------------
//Örnek 1
Anne anne = new Anne();
Baba baba = new Baba();
Cocuk cocuk = new Cocuk();

anne.adi = "** Fahriye";
anne.soyad = "Gökyar";
anne.AdSoyad(anne.adi, anne.soyad);
anne.Oku(anne.adi);
baba.adi = "** Kasım";
baba.soyad = "Gökyar";
baba.AdSoyad(baba.adi, baba.soyad);
baba.Oku(baba.adi);
cocuk.adi = "İbrahim";
cocuk.soyad = "Gökyar";
cocuk.AdSoyad(cocuk.adi, cocuk.soyad);

//Örnek 2 
Bmw bmw = new Bmw();
Ferrari ferrari = new Ferrari();
Porsche porsche = new Porsche();
bmw.Marka = "Bmw";
bmw.Model = "M3";
arb.EkranYaz(bmw.Marka, bmw.Model);
ferrari.Marka = "Ferrari ";
ferrari.Model = "La Ferrari";
arb.EkranYaz(ferrari.Marka, ferrari.Model);
porsche.Marka = "Porsche";
porsche.Model = "911 Gt3 RS";
arb.EkranYaz(porsche.Marka, porsche.Model);




//Örnek 3

AkilliCocuk ak = new AkilliCocuk();
ak.adi = "Hakan";
ak.soyad = "Yılmaz ";
ak.sifat = "--Akıllıdır";
ak.adSoyadSifatYaz(ak.adi, ak.soyad, ak.sifat);

UsluCocuk us = new UsluCocuk();
us.adSoyadSifatYaz("Mehmet", "Yıldız", "--Usludur");









Console.ReadKey();

