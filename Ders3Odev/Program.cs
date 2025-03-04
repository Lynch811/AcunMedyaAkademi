
using Ders3Odev.AbstractionOdev.Abstract;
using Ders3Odev.AbstractionOdev.Classes;
//--------------------------- Abstraction Ödevi -1- -----------------------------------
Bmw bmw = new Bmw();
Mercedes mercedes = new Mercedes();
Porsche porsche = new Porsche();
Console.WriteLine("***************************************************");
bmw.Marka = "Bmw";
mercedes.Marka = "Mercedes";
porsche.Marka = "Porsche";

bmw.AracHızı(bmw.Marka);
bmw.AracYuzme(bmw.Marka);
bmw.AracUcma(bmw.Marka);

mercedes.AracUcma(mercedes.Marka);
mercedes.AracYuzme(mercedes.Marka);

porsche.AracUcma(porsche.Marka);


//--------------------------- Abstraction Ödevi -2- -----------------------------------
GenelMudur genelMudur = new GenelMudur();
Mudur mudur = new Mudur();
Programci programci = new Programci();
Stajyer stajyer = new Stajyer();

int Maas = 0;
Maas += genelMudur.MaasinizNedir();
Maas += mudur.MaasinizNedir();
Maas += programci.MaasinizNedir();
Maas += stajyer.MaasinizNedir();
Console.WriteLine("***************************************************");
Console.WriteLine("-" + " Genel Mudur Maaşı:" + genelMudur.MaasinizNedir());
Console.WriteLine("-" + " Mudur Maaşı:" + mudur.MaasinizNedir());
Console.WriteLine("-" + " Programcı Maaşı:" + programci.MaasinizNedir());
Console.WriteLine("-" + " Stajyer Maaşı:" + stajyer.MaasinizNedir());
Console.WriteLine("--" + " Çalışanların Toplam Maaşı:" + Maas);

//--------------------------- Abstraction Ödevi -3- -----------------------------------
BmwYakitTuketimi bmwYakitTuketimi =new BmwYakitTuketimi();
MercedesYakitTuketimi mercedesYakitTuketimi = new MercedesYakitTuketimi();
PorscheYakitTuketimi porscheYakitTuketimi = new PorscheYakitTuketimi();
double aracYakitTuketimi = 0;
aracYakitTuketimi += bmwYakitTuketimi.YakitTuketiminizNedir();
aracYakitTuketimi += mercedesYakitTuketimi.YakitTuketiminizNedir();
aracYakitTuketimi += porscheYakitTuketimi.YakitTuketiminizNedir();
Console.WriteLine("***************************************************");
Console.WriteLine("^" + "Bmw Yakıt Tüketimi:" + bmwYakitTuketimi.YakitTuketiminizNedir()+"L");
Console.WriteLine("^" + "Mercedes Yakıt Tüketimi:" + mercedesYakitTuketimi.YakitTuketiminizNedir()+"L");
Console.WriteLine("^" + "Porsche Yakıt Tüketimi:" + porscheYakitTuketimi.YakitTuketiminizNedir()+"L");
Console.WriteLine("^^" + " Araçların Toplam Yakıt Tüketimi:" + aracYakitTuketimi+"L");

Console.ReadKey();