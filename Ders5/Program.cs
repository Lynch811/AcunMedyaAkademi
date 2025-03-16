using Ders5.Classes;
using Ders5.Constructors;

Insan i = new Insan("Hakan","yılmaz");
Console.WriteLine(i.adi+i.soyad);


Goz goz = new Goz("Kahverengi");
Kulak kulak = new Kulak("Kepçe");
Burun burun = new Burun("Kemer");
Kafa kafa = new Kafa(goz,kulak,burun);

YeniInsan yeni = new YeniInsan(kafa,"Talha","Arslan");
yeni.randevuKaydet();