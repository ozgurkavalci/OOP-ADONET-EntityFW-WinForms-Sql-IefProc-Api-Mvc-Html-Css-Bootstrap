using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim_Personel_Örnegi
{
    internal class Muhasebesubclass:Personel
    {
        public int gelir;
        public int gider;
        public int cariacik;


        public void muhasebeanaekran()
        {
            Console.WriteLine("Muhasebe ana menuye hosgeldiniz");
            Console.WriteLine("1-Bireysel Islemler");
            Console.WriteLine("2-Kurumsal bilanco");
            int muhasebesecim=Convert.ToInt32(Console.ReadLine());
            if (muhasebesecim == 1)
            {
                PersonelSoruEKranı();
                Console.WriteLine("Hesaplanan seans ucreti bonusunuz:" + SeansUcretihesapla(seans, ucret));
                Primhesapla(statu, yas, seans, ucret);
                
                Console.WriteLine(mezuniyet +" derecesine sahip oldugunuz icin eski " + ucret + " TL lik maasinizin zamli hali :" + Zamyap(mezuniyet, ucret));
            }

            else if (muhasebesecim == 2)
            {
                Console.WriteLine("Lutfen departman ya da bunyenizdeki personel sayisini giriniz:");
                int personelsayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lutfen ortalama personel giderinizi giriniz:");
                int personelgider=Convert.ToInt32(Console.ReadLine());
                gider = personelsayi * personelgider;
                Console.WriteLine("Lutfen yillik cironuzu giriniz:");
                gelir=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gecen yilki cari acik durumunuzu giriniz:");
                cariacik=Convert.ToInt32(Console.ReadLine());   


                Cariacik(gelir, gider, cariacik);
            }
            else
            {
                Console.WriteLine("Gecerli bir secim yapmadiginiz icin sistemden cikiliyor.");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }

            

        }


        public void Cariacik(int gelir, int gider,int cariacik)
        {
            if (gelir-gider>=150000)
            {
                int buyil=(gelir-gider) * 18 / 100;
                Console.WriteLine("Gecen yilki cari aciginiz:"+cariacik);
                Console.WriteLine("Gelir gider farkınınız 150000 Tl den fazla oldugu icin yüzde 18 Kdv cari acıgına eklenmistir. Bu yilki cari aciginiz:"+buyil);
            }

            else
            {
                
                int buyil = (gelir - gider) * 8 / 100;
                Console.WriteLine("Gecen yilki cari aciginiz:" + cariacik);

                Console.WriteLine("Gelir gider farkınınız 150000 Tl den az oldugu icin yüzde 8 Kdv cari acıgıniza eklenmistir. Bu yilki cari aciginiz:"+buyil);
            }
        
        
        }

        public override void Primhesapla(string statü, int yas, string seans, int ucret)
        {
            if (statü.ToLower()=="A" && seans.ToLower()=="evet" && yas>=35 )
            {
                int prim= ucret*10 / 100;
                Console.WriteLine("Prim miktariniz:"+prim);
            }
            else if (statü.ToLower() == "A" && seans.ToLower() == "evet" && yas <= 35)
            {
                int prim = ucret * 8 / 100;
                Console.WriteLine("Prim miktariniz:" + prim);
            }

            else if (statü.ToLower() == "A" && seans.ToLower() == "hayir" && yas <= 35)
            {
                int prim = ucret * 5 / 100;
                Console.WriteLine("Prim miktariniz:" + prim);
            }
            else if (statü.ToLower() == "A" && seans.ToLower() == "hayir" && yas >= 35)
            {
                int prim = ucret * 6 / 100;
                Console.WriteLine("Prim miktariniz:" + prim);
            }
            else
            {
                int prim = ucret * 4 / 100;
                Console.WriteLine("Prim miktariniz:" + prim);
            }
        }

        public override int SeansUcretihesapla(string seans, int ucret)
        {
            if (seans.ToLower()=="evet")
            {
                int seansucreti;
                seansucreti = ucret*108 / 100;
                return seansucreti;
            }
            else
            {
                return 0;
            }
        }

        public override int Zamyap(string mezuniyet, int ucret)
        {

            if (mezuniyet.ToLower() == "lisans")
            {
                ucret =ucret* 125 / 100;

                return ucret;
            }
            else if (mezuniyet.ToLower() == "lise")
            {
                ucret= ucret * 115 / 100;
                return ucret;


            }
            else
            {
                ucret = ucret * 108 / 100;
                return ucret;
            }
            
        }
    }
}
