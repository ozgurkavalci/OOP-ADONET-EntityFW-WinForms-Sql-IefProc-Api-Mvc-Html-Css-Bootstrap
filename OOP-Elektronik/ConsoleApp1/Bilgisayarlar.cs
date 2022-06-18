using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Bilgisayarlar:Elektronik
    {
        public double harddiskboyutu;     // metotda double field da int idi ben double a cevirdim
        public string islemciadi;
        


        public void bilgisayarAnaMenu()
        {
            Console.WriteLine("******Bilgisayarlar**********");
            ElektronikAnamenu();
            Console.WriteLine();
            Console.WriteLine("Lutfen hard disk boyutunu giriniz:");
            harddiskboyutu =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lutfen islemci adini giriniz:");
            islemciadi = Console.ReadLine();
            //Kampanya(uretimyili, marka);
            Console.WriteLine();
            
            
            


            

            
        
        
        }




        public void bilgisayarfiyatCikti()

        {
            ElektronikZamIndirimCikti();
            Hesaplama(ilkindirimsonrasi, kdv, otv);




        }
        public override void Hesaplama(double fiyat, double kdv, double otv)
        {
            fiyat += fiyat * (otv / 100);
            fiyat += fiyat * (kdv / 100);
            Console.WriteLine("Urununuzun kdv ve otv eklendikten sonraki fiyati:" + fiyat);

        }
        public override void Kampanya(int uretimyili, string marka)
        {
            if (uretimyili <= 2018 && marka.ToLower() == "toshiba" || marka.ToLower() == "asus")
            {
                Console.WriteLine("Bu urunlerde yuzde 20 ye varan kampanya mevcut");
            }
            else
            {
                Console.WriteLine("Firsatlari kesfetmek icin alisverise devam edin...");
            }
        }
        public override double Zam(double fiyat)
        {

            if (fiyat <= 1000)
            {
                fiyat *= (105 / 100);
                return fiyat;
            }

            else
            {
                fiyat *= (110 / 100);
                return fiyat;
            }



            //return base.Zam(fiyat);
        }
        public override double Indirim(double fiyat)
        {
            if (fiyat <= 500)
            {
                fiyat *= (97 / 100);
                return fiyat;
            }
            else if (fiyat > 500 && fiyat <= 1000)
            {
                fiyat *= (95 / 100);
                return fiyat;
            }
            else
            {
                fiyat *= (92 / 100);
                return fiyat;
            }



            //return base.Indirim(fiyat);
        }


        public abstract void B_Fatura(double harddiskboyutu, string islemciadi,double fiyat,double kdv);

    }
}
