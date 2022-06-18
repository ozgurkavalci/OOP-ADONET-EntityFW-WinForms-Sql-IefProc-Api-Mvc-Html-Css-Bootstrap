using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Elektronik
    {
        private int urunno;


        public int Urunno
        { 
         get { return urunno; }
            set { urunno = value; }
        
        }

        public string urunadi;
        public string marka;
        public string model;
        public int uretimyili;
        public double fiyat;               // fiyat otv ve kdv int verilmisti ben double yaptim.
        public double otv;
        public double kdv;
        public double indirim;

        public double ilkzam;
        public double ilkindirimsonrasi;


        public abstract void Kampanya(int uretimyili, string marka);
        public abstract void Hesaplama(double fiyat, double kdv,double otv);


        public virtual double Zam(double fiyat)
        {
            if (fiyat<=1000)
            {
                fiyat *= (105 / 100);
                return fiyat;
            }

            else
            {
                fiyat *= (110 / 100);
                return fiyat;
            }
            
        }
        public virtual double Indirim(double fiyat)
        {
            if (fiyat<=500)
            {
                fiyat *= (97 / 100);
                return fiyat;   
            }
            else if (fiyat>500&& fiyat<=1000)
            {
                fiyat *= (95 / 100);
                return fiyat;
            }
            else
            {
                fiyat *= (92 / 100);
                return fiyat;
            }
            //fiyat +=fiyat* (otv/100);
            //fiyat += fiyat*(kdv / 100);
            //return fiyat;

            
        }

        public void ElektronikAnamenu()
        {

            Console.WriteLine("Urun adini giriniz:");
            urunadi=Console.ReadLine();
            Console.WriteLine("Urun markasini giriniz:");
            marka=Console.ReadLine();
            Console.WriteLine("Urun modelini giriniz:");
            model=Console.ReadLine();
            Console.WriteLine("Urun uretim yilini giriniz:");
            uretimyili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Urun fiyatini giriniz");
            fiyat=Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Urun OTV yuzdesini giriniz:");
            otv=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Urun KDV yuzdesini giriniz:");
            kdv=Convert.ToDouble(Console.ReadLine());
            // indirimi biz hesap edicez istemiyorum.

            Console.Clear();
            Console.WriteLine();
            
        
        
        
        }


        public void ElektronikAnaMenuCikti()
        {
            Console.WriteLine("Urun adi:"+urunadi);
            Console.WriteLine("Urun markasi:"+marka);
            Console.WriteLine("Urun modeli:"+model);
            Console.WriteLine("Urun uretim yili:"+uretimyili);
            Console.WriteLine("Urun giris fiyati:"+fiyat);
            Console.WriteLine("Urune uygulanan OTV:"+otv);
            Console.WriteLine("Urune uygulanan KDV:"+kdv);
        
        
        
        }
        public void ElektronikZamIndirimCikti()
        {

            ilkzam = Zam(fiyat);
            ilkindirimsonrasi=Indirim(ilkzam);

            Console.WriteLine("Urununuzun sadece fiyat bazli zam sonrasi fiyat:" + ilkzam);
            Console.WriteLine("Urununuzun sadece fiyat bazli indirim sonrasi fiyati:" + ilkindirimsonrasi);


        }
    }
}
