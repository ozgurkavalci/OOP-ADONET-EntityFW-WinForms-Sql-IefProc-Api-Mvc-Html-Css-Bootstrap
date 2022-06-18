using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnekk
{
    abstract class Hastane
    {

        public int hastano;
        public string hastaadsoyad;
        public string sgk;
        public int katkipayi;
        public int muayaneücreti;
        public int tahlil;
        public int receteücret;


        public abstract int Fark(string sgk, int tahlil);

        public virtual void Hemsire()
        {
            Console.WriteLine("Bashemsire Ceyda Hanım Kayserili felan değil.");
        
        
        }

        public virtual int Ödeme(int katki, int ücret)
        {

            return ücret + katki;
        
        }

        public void VeriAl()
        {
            Console.WriteLine("Hasta no giriniz:");
            hastano=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hasta ad ve soyadını giriniz:");
            hastaadsoyad=Console.ReadLine();
            Console.WriteLine("Sgk var mı");
            sgk=Console.ReadLine();
            Console.WriteLine("Katkı payını giriniz:");
            katkipayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Muayene ücretini giriniz:");
            muayaneücreti=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tahlil no giriniz:");
            tahlil=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Recete ücretini giriniz:");
            receteücret=Convert.ToInt32(Console.ReadLine());
        
        
        
        
        }

        public void Bas()
        {

            Console.WriteLine("Hasta no:"+hastano);
            Console.WriteLine("Ad soyad:"+hastaadsoyad);
            Console.WriteLine("Sgk :"+sgk);
            Console.WriteLine("Katkıpayı:"+katkipayi);
            Console.WriteLine("Muayane ücreti:"+muayaneücreti);
            Console.WriteLine("Tahlil:"+tahlil);
            Console.WriteLine("Recete ucret :"+receteücret);
        
        }

            
    }
}
