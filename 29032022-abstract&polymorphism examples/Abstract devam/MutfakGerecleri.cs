using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_devam
{
    internal class MutfakGerecleri : Gerecler
    {
        public int watt;
        public string wattdurum;

        public void Enerji(int watt, string wattdurum)
        {
            if (watt>4000)
            {
                Console.WriteLine("Yandın fatura gg no re");
            }
            else if(watt<4000&& wattdurum.ToLower()=="sarjli")
            {
                Console.WriteLine("A++ tasarruflu kazandın...");
            }
        
        }

        public override int Fatura(int fiyat, int adet)
        {
            if (adet>10 && adet<20)
            {
                fiyat -= fiyat * 10 / 100;
                return fiyat;

            }
            else
            {
                return fiyat;
            }
        }

        public override void KategoriBelirle(string gereckategori)
        {
            if (gereckategori.ToLower()=="Porselen")
            {
                Console.WriteLine("Güral porselen tercihimizdir.");
            }
            else
            {
                Console.WriteLine("Başka markalarla çalışmayız kırılıyooo..");
            }
        }
    }
}
