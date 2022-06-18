using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_base_class_abstract_örnegi__CTOR_SONRASI_
{
    abstract class ev
    {
        // base class                 // verı al ve verıyazdır metodları burada

        public int evno;
        public string evtipi;
        public int odasayisi;
        public double m2;
        public int emsalbedel;
        public int arsapayi;
        public string arsadurumu;
        public string iskandurumu;
        public int aidat;
        public int yoneticiucret;
        public double fiyat;

        





        public void SoruEkranı()
        {
            Console.WriteLine("Konut noyu giriniz:");
            evno=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Oda sayısını giriniz:");
            odasayisi= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Metrekareyi giriniz:");
            m2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Emsalbedeli giriniz:");
            emsalbedel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arsapayı ucretını giriniz:");
            arsapayi= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Arsa imar durumunu giriniz :(var/yok)");
            arsadurumu= Console.ReadLine();
            Console.WriteLine("İskan durumunu giriniz:(var/yok)=");
            iskandurumu= Console.ReadLine();
            Console.WriteLine("Aidat miktarını giriniz:");
            aidat= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yonetici ücretini giriniz:");
            yoneticiucret= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fiyat miktarını giriniz:");
            fiyat= Convert.ToDouble(Console.ReadLine()); 
                   
           
        }

        public void EkranCıktısıev()
        {

            Console.WriteLine("Konut no:" + evno);

            Console.WriteLine("Oda sayısı:" + odasayisi);

            Console.WriteLine("Metrekare:" + m2);

            Console.WriteLine("Emsalbedeli:" + emsalbedel);


            Console.WriteLine("Arsapayı ucretı:" + arsapayi);

            Console.WriteLine("Arsa imar durumunu:" + arsadurumu);

            Console.WriteLine("İskan durumu:" + iskandurumu);

            Console.WriteLine("Aidat miktarını giriniz:" + aidat);

            Console.WriteLine("Yonetici ücreti:" + yoneticiucret);

            Console.WriteLine("Fiyat miktarı:" + fiyat);

        }



        public abstract void Teklifler(double fiyat);

        public virtual double Evzam(int odasayisi, double m2, double fiyat)
        {

            if (odasayisi>=4 || m2>=120)
            {
                return fiyat *= 1.18;
            }
            else
            {
                return fiyat *= 1.08;
            }
        
        
        }

        // arsadurumu imarlı ise iskan durumu varsa fiyat / m2 den m2 bası fiyat bulunacak 
        // eger ımarsız ıse ıskan da yoksa  fiyat/m2 fiyatı yüzde 10 azaltıcalackç


        public double Metrekarebasifiyat(string arsadurumu, string iskandurumu, double m2, double fiyat)
        {

            if (arsadurumu.ToLower()=="var" && iskandurumu.ToLower()=="var")
            {
                return fiyat / m2;
            }
            else
            {
                return fiyat / m2 * 0.9;
            }
        
        }



    }
}
