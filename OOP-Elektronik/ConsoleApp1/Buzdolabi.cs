using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Buzdolabi : Elektronik
    {
        public double kaliteorani;
        public double kapasite;
        public string sogutmaayari;
        public double otvindirimioncesifiyat;


        public void BuzdolabiAnaMenu()
        {
            Console.WriteLine("********Buzdolabi secimi*********");
            ElektronikAnamenu();
            Console.WriteLine("Buzdolabi kalite oranini giriniz:");
            kaliteorani =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Buzdolabi kapasitesini giriniz:");
            kapasite=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Buzdolabi sogutma ayarini giriniz:");
            sogutmaayari =Console.ReadLine();
            Console.WriteLine();
            
            ElektronikAnaMenuCikti();
            Console.WriteLine();
            Console.WriteLine("Buzdolabi kalite orani:"+kaliteorani);
            Console.WriteLine("Buzdolabi kapasitesi:"+kapasite);
            Console.WriteLine("Buzdolabi sogutma ayari:"+sogutmaayari);
            Console.WriteLine();
            Kampanya(uretimyili, marka);

            Hesaplama(fiyat, kdv, otv);
            Console.WriteLine();
            fiyat += fiyat * (otv / 100);
            fiyat += fiyat * (kdv / 100);
            otvindirimioncesifiyat = fiyat;
            Console.WriteLine("Urununuzun OTV indirimi sonrasi fiyati:"+OtvIndirim(otvindirimioncesifiyat,otv,kaliteorani,kapasite));



        }

        public override void Hesaplama(double fiyat, double kdv, double otv)
        {
            fiyat += fiyat * (otv / 100);
            fiyat+= fiyat* (kdv / 100);
            Console.WriteLine("Urununuzun kdv ve otv eklendikten sonraki fiyati:"+fiyat);
            
        }

        public override void Kampanya(int uretimyili, string marka)
        {
            if (uretimyili <= 2018 && marka.ToLower() == "arcelik" || marka.ToLower() == "bosh")
            {
                Console.WriteLine("Bu urunlerde yuzde 20 ye varan kampanya mevcut");
            }
            else
            {
                Console.WriteLine("Firsatlari kesfetmek icin alisverise devam edin...");
            }
            
            
        }

        public double OtvIndirim(double fiyat, double otv, double kaliteorani, double kapasite)
        {

            if (kaliteorani >= 95 && kapasite >= 550)
            {
                fiyat-= 650;
                return fiyat;
            }
            else if (kaliteorani < 95 && kaliteorani >= 85 && kapasite >= 450)
            { 
               return fiyat -=  550;
            
            }
            else if (kaliteorani < 95 && kaliteorani >= 85 && kapasite >= 350)
            {
                return fiyat-=450;
            }
            else if (kaliteorani < 85 && kaliteorani >= 65 && kapasite >= 250)
            {
                return fiyat-=350;
            }
            else if(kapasite>=600)

            {
                return fiyat -=250;
            }
            else
            {
                return fiyat -=150;
            }

            
        
        }
    }
}
