
//Örnek 1
using Ders3.Abstracts;
using Ders3.Classes;



Anne anne = new Anne();
Baba baba = new Baba();
Cocuk cocuk = new Cocuk();

anne.adi = "** Fahriye";
anne.soyad = "Gökyar";
anne.AdSoyad(anne.adi, anne.soyad);
anne.Oku(anne.adi);
anne.dinle(anne.adi);
anne.yaz(anne.adi);
baba.adi = "** Kasım";
baba.soyad = "Gökyar";
baba.AdSoyad(baba.adi, baba.soyad);
baba.Oku(baba.adi);
cocuk.adi = "İbrahim";
cocuk.soyad = "Gökyar";
cocuk.AdSoyad(cocuk.adi, cocuk.soyad);

//----------------------------------------------------------------
AkilliCocuk ak = new AkilliCocuk();
ak.adi = "Hakan ";
ak.askeregit(ak.adi);
ak.ehliyetal(ak.adi);
ak.klubegit(ak.adi);


UsluCocuk uslu = new UsluCocuk();
uslu.adi = "Mehmet ";
uslu.askeregit(uslu.adi);
uslu.ehliyetal(uslu.adi);

HiperAktifCocuk hiperAktifCocuk = new HiperAktifCocuk();
hiperAktifCocuk.adi = "Hüseyin ";
hiperAktifCocuk.ehliyetal(hiperAktifCocuk.adi);


Bmw bmw = new Bmw();
Porsche porsche = new Porsche();
Ferrari ferrari = new Ferrari();

bmw.Marka = "Bmw";
porsche.Marka = "Porsche";
ferrari.Marka = "Mercedes";

bmw.arachızlıgidiyor(bmw.Marka);
bmw.aracgittigiyol(bmw.Marka);
bmw.havadauc(bmw.Marka);


ferrari.arachızlıgidiyor(ferrari.Marka);
ferrari.aracgittigiyol(ferrari.Marka);

porsche.arachızlıgidiyor(porsche.Marka);
//abstract class ların nesnesi oluşturulamaz
//Calisan calisan = new Calisan();

GenelMudur genelMudur = new GenelMudur();
Mudur	mudur = new Mudur();	
Programci programci = new Programci();
Stajyer stajyer = new Stajyer();

double toplammaas = 0.0;
toplammaas += genelMudur.maasinizNedir();
toplammaas += mudur.maasinizNedir();
toplammaas += programci.maasinizNedir();
toplammaas += stajyer.maasinizNedir();

Console.WriteLine("Toplam Maas " + toplammaas + " Tl maas alıyorlar");

Bmw2 bmw2 = new Bmw2();
Porsche2 porsche2 = new Porsche2();
Mercedes mercedes = new Mercedes();

double yakit = 0.0;
yakit += bmw2.yakıttuketimi();
yakit += porsche2.yakıttuketimi();
yakit += mercedes.yakıttuketimi();

Console.WriteLine("Toplam yakıt: "+ yakit);