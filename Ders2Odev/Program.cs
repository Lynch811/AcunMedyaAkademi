using Ders2Odev.Classes;


Audi audi = new Audi();
audi.EkranYaz("Audi", "S3Line", "Dizel", 1);

Bmw bmw = new Bmw();
bmw.EkranYaz("Bmw", "M3 Competition", "Benzin", 0);

Mercedes mercedes = new Mercedes();
mercedes.EkranYaz("Mercedes", "S Class", "Dizel", 1);

Porsche porsche = new Porsche();
porsche.EkranYaz("Porsche", "911GT3RS", "Benzin", 1);

Togg togg = new Togg();
togg.EkranYaz("Togg", "T10X", "Elektrik", 1);


Toyata toyata = new Toyata();
toyata.EkranYaz("Toyota", "Gt86", "Benzin", 1);



Console.ReadKey();
