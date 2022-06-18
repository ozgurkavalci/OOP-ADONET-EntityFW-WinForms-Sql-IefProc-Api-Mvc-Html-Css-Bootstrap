using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25032022_OOP_çicekböcek
{
    class Asker
    {

        //asker class ı ac, // ad soyad yas meslek bolum mezunıyet maas
        // 2 tane method
        // return bolumune gore gunluk ucret mıktarından maas hesapla

        //void  meslek mühendis ve doktor olanlar  her hafta sonu geziye çıkabilsin
        // diğer meslek sahipleri 2 haftada bir çarşıya çıkabilsin


        public string ad;
        public string soyad;
        public int yas;
        public string meslek;
        public string bolum;
        public string mezuniyet;
        public int maas;


        public int MaasHesapla(int günlükUcret, int gün)
        {
            int maashesabı = günlükUcret * gün;
            return maashesabı;
        
        }

        public void carsıIznı(string dorm)
        {
            if (dorm.ToLower()=="doktor" || dorm.ToLower()=="mühendis")
            {
                Console.WriteLine("Her hafta carsı iznine çıkabilirsiniz");
            }
            else
            {
                Console.WriteLine("İki haftada bir çarşı iznine çıkabilirsiniz");
            }
        
        
        }
    }
}
