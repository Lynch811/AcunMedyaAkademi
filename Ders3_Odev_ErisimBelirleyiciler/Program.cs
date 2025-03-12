
using Ders3_Odev_ErisimBelirleyiciler.Classes;
User kullanici = new User();
kullanici.setAdSoyad("Talha Arslan");
kullanici.setYas(21);
kullanici.Email = "T@t.com";
Console.WriteLine("**************************************************");
Console.WriteLine("Ad Soyad: "+kullanici.getAdSoyad());
Console.WriteLine("Yaş: "+kullanici.getYas());
Console.WriteLine("Email: "+kullanici.Email);
Console.WriteLine("**************** Bilgileri Göster ****************");
kullanici.bilgileriGoster();
Console.WriteLine("**************************************************");
Console.ReadLine();
