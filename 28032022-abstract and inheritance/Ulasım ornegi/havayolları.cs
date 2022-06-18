using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulasım_ornegi
{
    public class havayolları:ulasımbaseclass
    {
        private string firmaadı;
        private string seferyeri;
        private string sefergünü;
        private int motorsayısı;
        private double bagajfiyat;
        private double bagajkg;


        public string Firmaadı
        { get { return firmaadı; }
            set { firmaadı = value; }

        }

        public string Seferyeri
        {
            get { return seferyeri; }
            set { seferyeri = value; }

        }
        public string Sefergünü
        {
            get { return sefergünü; }
            set { sefergünü = value; }

        }
        public int Motorsayısı
        {
            get { return motorsayısı; }
            set { motorsayısı = value; }

        }
        public double Bagajfiyat
        {
            get { return bagajfiyat; }
            set { bagajfiyat= value; }

        }
        public  double Bagajkg
        {
            get { return bagajkg; }
            set { bagajkg= value; }

        }

        public void Havayolları()
        {





            heryerdeaynı();
            Console.WriteLine("Firma adını giriniz:");
            Firmaadı=Console.ReadLine();
            Console.WriteLine("Sefer yerini giriniz:");
            gotoseferyeri:
            Seferyeri=Console.ReadLine();
            Console.WriteLine("Sefer gününü giriniz:");
            Sefergünü=Console.ReadLine();   
            Console.WriteLine("Motor sayısını giriniz: ");
            Motorsayısı = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bagaj fiyatını giriniz:");
            Bagajfiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bagaj kg ını giriniz:");
            Bagajkg=Convert.ToDouble(Console.ReadLine());
            double ulasımdangelen=Fiyathesabı(Biletfiyat, duraksayisi);

            SeferBilgisi(Seferyeri, Sefergünü);
            if (Seferyeri.ToLower() == "antalya" && Sefergünü.ToLower() == "carsamba" || Sefergünü.ToLower() == "cuma")
            {
                goto gotoseferyeri;
            }
            else if (Seferyeri.ToLower() == "ağrı" || Seferyeri.ToLower() == "ığdır" && Sefergünü.ToLower() == "cumartesi" || Sefergünü.ToLower() == "pazar")
            { 
                goto gotoseferyeri;
            }

            Console.WriteLine("Bilet içinb ödemeniz gereken tutar:"+Havayoluzam(Firmaadı,ulasımdangelen,Motorsayısı));
            Console.WriteLine("Bagaj için ödemeniz gereken tutar:"+Bagajfiyatı(Bagajkg,Bagajfiyat));





        }

        public double Havayoluzam(string firmaadı, double ulasımdangelenfiyat, int motorsayisi)
        {

            double donendeger = 0;

            if (motorsayisi>=3 && firmaadı.ToLower()=="pegasus")
            {
                donendeger = ulasımdangelenfiyat * 1.4;
                donendeger *= 1.02;
                return donendeger;
            }

            else if (motorsayisi < 3 && firmaadı.ToLower() == "onurair")
            {
                donendeger = ulasımdangelenfiyat * 1.3;
                donendeger *= 1.04;
                return donendeger;

            }
            return donendeger;
          
        
        }

        public double Bagajfiyatı(double bagajkg, double bagajfiyat)
        {
            double bagajtoplam;

            bagajtoplam = bagajkg * bagajfiyat;
            return bagajtoplam;
        
          
          
        
        }

        public void SeferBilgisi(string seferyeri, string sefergünü)
        {

            if (seferyeri.ToLower()=="antalya" && sefergünü.ToLower()=="carsamba" || sefergünü.ToLower()=="cuma")
            {
                Console.WriteLine("Antalya konumuna çarşamba ve cuma günleri sefer yoktur.");
                

            }
            else if (seferyeri.ToLower() == "ağrı" || seferyeri.ToLower() == "ığdır" && sefergünü.ToLower() == "cumartesi" || sefergünü.ToLower() == "pazar")
            {
                Console.WriteLine("Ağrı ve Iğdır konumlarına haftasonu sefer yoktur.");
            }
        
        
        }
        

    }
}
