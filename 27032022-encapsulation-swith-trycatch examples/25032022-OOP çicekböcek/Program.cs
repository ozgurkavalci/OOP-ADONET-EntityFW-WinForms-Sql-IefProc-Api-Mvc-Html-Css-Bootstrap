using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25032022_OOP_çicekböcek
{
    class Program
    {
        static void Main(string[] args)
        {
         //git:
         //   Console.WriteLine("1-Düğün çiçeği");
         //   Console.WriteLine("2-Cenaze çiceği");
         //   int secenek = Convert.ToInt32(Console.ReadLine());
         //   if (secenek == 1)
         //   {
         //       //hata yakalama komutları
         //       // try--->kod yaz hata var mı yok mu kontrol et
         //       // catchh----- > yakala , eger try hata olustu ıse catch ootomatık   olarak hatayı bulur yakalar
         //       //finally---> her iki durumda da en son girmesini istediğimiz alandır ,yazılması şart değildir.
         //       // throw---> kendi hatamızı kendimiz yazmak istersek o zaman kullanırız.
         //       // runtime (calısma zamanı hataları)
         //       //syntax hatalar(kod yazarken kurallar dısında olusan hatalara denir)

         //       try
         //       {

         //           Flower cicek1 = new Flower();
         //           Console.WriteLine("Çiçek adı giriniz:");
         //           cicek1.cicekAdi = Console.ReadLine();
         //           Console.WriteLine("Renk giriniz:");
         //           cicek1.renk = Console.ReadLine();
         //           Console.WriteLine("Koku durumu giriniz:");
         //           cicek1.kokudurumu = Console.ReadLine();
         //           Console.WriteLine("Fiyat giriniz:");
         //           cicek1.fiyat = Convert.ToInt32(Console.ReadLine());
         //           Console.WriteLine("Adet giriniz:");
         //           cicek1.adet = Convert.ToInt32(Console.ReadLine());


         //           Console.WriteLine("Ödemeniz gerken tutar:" + cicek1.fiyatHesapla(cicek1.adet, cicek1.fiyat));
         //           cicek1.Ozellik(cicek1.cicekAdi, cicek1.renk);

         //       }
         //       catch
         //       {
         //           Console.WriteLine("hata yakalandı ,işlemi kontrol ediniz.");
         //           goto git;
         //       }

         //       Console.ReadLine();

         //   }

         //   else if (secenek == 2)
         //   {
         //       Flower cicek2 = new Flower();
         //       Console.WriteLine("Çiçek adı giriniz:");
         //       cicek2.cicekAdi = Console.ReadLine();
         //       Console.WriteLine("Renk giriniz:");
         //       cicek2.renk = Console.ReadLine();
         //       Console.WriteLine("Koku durumu giriniz:");
         //       cicek2.kokudurumu = Console.ReadLine();
         //       Console.WriteLine("Fiyat giriniz:");
         //       cicek2.fiyat = Convert.ToInt32(Console.ReadLine());
         //       Console.WriteLine("Adet giriniz:");
         //       cicek2.adet = Convert.ToInt32(Console.ReadLine());


         //       Console.WriteLine("Ödemeniz gerken tutar:" + cicek2.fiyatHesapla(cicek2.adet, cicek2.fiyat));
         //       cicek2.Ozellik(cicek2.cicekAdi, cicek2.renk);


         //   }


            askeranaekran:
            Console.WriteLine("****Asker Kişi ve İzin bilgileri sorgulama ekranına hosgeldiniz.");
            Asker yeniasker = new Asker();
            try
            {
                
                Console.WriteLine("Asker adi giriniz:");
                yeniasker.ad = Console.ReadLine();
                Console.WriteLine("Asker soyadi giriniz:");
                yeniasker.soyad = Console.ReadLine();
                Console.WriteLine("Asker yaşı giriniz:");
                yeniasker.yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Asker meslegi giriniz:");
                yeniasker.meslek = Console.ReadLine();
                Console.WriteLine("Asker bolumu giriniz:");
                yeniasker.bolum = Console.ReadLine();
                Console.WriteLine("Asker mezuniyet türünü giriniz(Lisans veya diğerleri)");
                yeniasker.mezuniyet = Console.ReadLine();
                Console.WriteLine("Günlük ücret bilginizi giriniz:");
                yeniasker.maas = Convert.ToInt32(Console.ReadLine());
                int gün = 30;

                Console.WriteLine("Almanız gerken maas:" + yeniasker.MaasHesapla(yeniasker.maas, gün));

                yeniasker.carsıIznı(yeniasker.meslek);
            }
            catch
            {
                Console.WriteLine("Hatali veri girisi yaptiniz ana ekrana yonlendiriliyorsunuz...");
                goto askeranaekran;

            }
            Console.ReadLine();

















        }

    }

}
