using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28032022_abstarcy_ornek
{
    abstract class sandalye
    {

        public int urunno;
        public string marka;
        public string model;
        public int kdv;
        public int fiyat;

        public abstract int ZamYap(string model, int fiyat);

        public abstract void KdvHesapla(int fiyat);

        public void HediyeKampanya(string marka, string model)
        {
            if (marka=="bellona"&&model=="klasik")
            {
                Console.WriteLine("Ütü kazandınız.");
            }
            else
            {
                Console.WriteLine("Paspas kazandınız");
            }
        }

        public void Verial()
        {
            Console.WriteLine("Sandalye No giriniz:");
            urunno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marka giriniz:");
            marka=Console.ReadLine();
            Console.WriteLine("Model No giriniz:");
            model = Console.ReadLine();
            Console.WriteLine("Kdv giriniz:");
            kdv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fiyat giriniz:");
            fiyat = Convert.ToInt32(Console.ReadLine());




        }


        public void Bas()
        {

            Console.WriteLine("sandalye no:"+urunno);
            Console.WriteLine("Marka:" + marka);
            Console.WriteLine("Model" + model);
            Console.WriteLine("KDV:"+kdv);
            Console.WriteLine("fiyat:"+fiyat);
        
        
        }
        
    }
}
