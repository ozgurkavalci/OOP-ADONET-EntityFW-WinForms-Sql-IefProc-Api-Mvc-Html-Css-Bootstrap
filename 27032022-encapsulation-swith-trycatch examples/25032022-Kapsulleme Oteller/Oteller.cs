using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25032022_Kapsulleme_Oteller
{
    class Oteller
    {
        public int ensonfiyat;

        // Oteller 

        //------------

        //otelNo

        //oteladi

        //otelpuan

        //gunlukfiyat

        //kalacaagı gun



        //1- Otel no sadece 4 hane olacak.

        //2- Kalıte 3 yıldızdan aşagı ıse kapancak not verin

        // 3-Kalacagı gun 2 gunden az olamaz





        //EK OZELLIK (OTEL KALITE VE OTEL PUANINA,GÜNLÜKFİYAT, KALACAGI GUN )--> KALİTE 4 TEN BUYUK VE PUAN 7 DEN BUYUK ISE   VOIDLE YAPILCAK SONRA ICINE FATURAYI

        // A- SAUNA
        //B-jAKUZİ
        //C-IKISIDE


        //SWITCH LE YAP

        // EGER SAUNA SECERSE FIYATA YUZDE 2O ZAM
        // EGER JAKUZİ İSE YÜZDE 15 
        // EGER IKISINI DE SECERSE FİYATA YUZDE20+YUZDE 12.5

        //FATURADEME(RETURN)

        //FİYAT KALACAGI GUN 3 ILE 5 ARASINDA ISE ---> FİYATA +%2 ÖTV

        //EGER KALACAGI GUN 5 ILE 8 ARASINDA ISE ---->FİYATA +%8ÖTV



        // ANA SAYFA

        //1-kRAL ODASI(SWİTCH)
        //2-STANDART ODA




        private string otelNo;
        private string otelAdi;
        private int otelKalite;
        private int otelPuan;
        private int günlükFiyat;
        private int kalacagiGun;



        public string OTELNO
        {
            get { return otelNo; }
            set
            {

                if (value.Length == 4)
                {
                    Console.WriteLine(value + " otel numarası icin islem yapılacaktir.");
                    otelNo = value;
                }
                else
                {
                    Console.WriteLine("Geçerli bir otel numarısı girmediniz . Lütfen 4 haneli bir otel oda numarısı giriniz");


                }

            }

        }


        public string OTELADI
        {
            get { return otelAdi; }
            set
            {
                otelAdi= value;

            }

        }




        public int OTELKAL
        {
            get { return otelKalite; }
            set
            {
                if (value > 3)
                {
                    
                    otelKalite = value; 
                }
                else
                {
                    Console.WriteLine("3 Yıldız altındaki oteller kapanacaktır.");
                    otelKalite = value;
                }

            }

        }


        public int OTELPUAN
        {
            get { return otelPuan; }
            set
            {
                 otelPuan= value;

            }
        }





        public int GUNLUKFIYAT
        {
            get { return günlükFiyat; }
            set
            {
                günlükFiyat = value;
            }



        }

        public int KALACAKGUN
        {
            get { return kalacagiGun; }
            set
            {
                kalacagiGun = value;

            }

        }


        public void ekOzellik(int otelkalitesi,int otelpuani,int kalacagigun,int gunlukbayilanmebla)
        {
            
            if (otelkalitesi > 4 && otelpuani > 7)
            {
                

                Console.WriteLine("VIP misafirlerimize ozel ek paket secimine hos geldiniz.");
                Console.WriteLine("1-Sauna");
                Console.WriteLine("2-Jakuzi");
                Console.WriteLine("3-Jakuzi ve Sauna");
                Console.WriteLine("lutfen bir paket secimi yapiniz:");
                int ekozellikanasecim = Convert.ToInt32(Console.ReadLine());
                switch (ekozellikanasecim)
                {
                    case 1:
                        Console.WriteLine("Sadece sauna seciminiz faturaniza %20 zam seklinde yansitilacaktir.");
                        ensonfiyat = kalacagigun * gunlukbayilanmebla * 120 / 100;
                        Console.WriteLine("Odemeniz gereken toplam tutar:"+faturaHesabi(kalacagigun,ensonfiyat));
                        


                        break;

                    case 2:

                        Console.WriteLine("Sadece Jakuzi seciminiz faturaniza %15 zam seklinde yansitilacaktir.");
                        ensonfiyat = kalacagigun * gunlukbayilanmebla * 115 / 100;
                        Console.WriteLine("Odemeniz gereken toplam tutar:" + faturaHesabi(kalacagigun,ensonfiyat));
                        break;

                    case 3:
                        Console.WriteLine("Jakuzi ve sauna ikili paket seciminiz faturaniza %20+%12.5 zam seklinde yansitilacaktir.");
                        ensonfiyat = kalacagigun * gunlukbayilanmebla * 120 / 100;
                        ensonfiyat += ensonfiyat*125/1000;
                        Console.WriteLine("Odemeniz gereken toplam tutar:" + faturaHesabi(kalacagigun, ensonfiyat));
                        break;

                    
                }


            }

            else
            {
                ensonfiyat = kalacagigun * gunlukbayilanmebla;
                Console.WriteLine("Odemeniz gereken ucret: "+ensonfiyat);
            }



        }

        public int faturaHesabi(int gunsayisi,int finalfiyat)
        {
            
            if (3<=gunsayisi && gunsayisi<5)
            {
                
                finalfiyat+= finalfiyat*2 / 100;
                return finalfiyat;
            }

            
            else
            {
                
                finalfiyat += finalfiyat * 8 / 100;
                return finalfiyat;
            }

        }







        public  void Anasayfa()
        {
            Console.WriteLine("********ODA SECIMI************");
            Console.WriteLine("Oda tercihleri asagıdakı gibidir.");
            Console.WriteLine("1-Kral Odası");
            Console.WriteLine("2-Standart Oda");
            Console.WriteLine("Lutfen bir secim yapınız:");
            int odatürüsecimi = Convert.ToInt32(Console.ReadLine());
            switch (odatürüsecimi)
            {
                case 1:
                    otelnumarasial:
                    Console.WriteLine("Lutfen bir otel numarası giriniz.");
                    string otelNo=Console.ReadLine();
                    if (otelNo.Length==4)
                    {
                        OTELNO = otelNo;
                    }
                    else
                    {
                        Console.WriteLine("Lutfen Dort haneli bir otel numarisi tuslayiniz:");
                        goto otelnumarasial;
                    }

                    Console.WriteLine("Lutfen bir otel adi giriniz:");
                    OTELADI = Console.ReadLine();
                    Console.WriteLine("Lutfen otel kalitesini temsil eden yıldız sayısı giriniz");
                    OTELKAL = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lutfen otel puanını giriniz.");
                    OTELPUAN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Günlük ücreti giriniz:");
                    GUNLUKFIYAT = Convert.ToInt32(Console.ReadLine());
                    kalacakgunaraci:
                    Console.WriteLine("Kac gün kalacaksınız:");
                    int kalacakgunaraci=Convert.ToInt32(Console.ReadLine());
                    if (kalacakgunaraci<3)                  
                    {
                        Console.WriteLine("3 gunden daha az rezervasyon yapilamamaktadir. Lutfen gecerli bir secim yapiniz.");
                        goto kalacakgunaraci;
                    }
                    else
                    {
                        KALACAKGUN = kalacakgunaraci;
                    }

                    ekOzellik(otelKalite, otelPuan, kalacagiGun, günlükFiyat);
                    Console.ReadLine();
                    



                    break;

                case 2:

                    break;

                default:
                    break;
            }






        }



    }
}
