using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25032022_OOP_çicekböcek
{
    class Flower
    {


        public string cicekAdi;
        public string renk;
        public string kokudurumu;
        public int fiyat;
        public int adet;


        public int fiyatHesapla(int adet,int fiyat)
        {
            int fatura = adet * fiyat;
            return fatura;
            
        }

        public void Ozellik(string ad,string renk)
        {
            if (ad=="gül" || ad=="kaktüs")
            {
                Console.WriteLine("Kırmızı ve sarı renklerimiz mevvuttur.Bir demet alana bir demet bedava gelinnn.");

            }
            else
            {
                Console.WriteLine("Diger ciceklerde %2 indirim var.");
            }
            
        
        }

    }
}
