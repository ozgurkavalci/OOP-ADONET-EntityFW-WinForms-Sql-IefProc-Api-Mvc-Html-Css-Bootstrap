using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25032022_Kapssulleme
{
    class Kolomyalar
    {
        public string markaadi;
        private int fiyat;
        private int üretimYılı;
        private string menşei;


        //encapsulation kapsülleme ,sırmalama
        // private field propertyler açıyoruz kullnıcıya
        // 2 anahtar kelime var 1. "get" 2. si ise "set"
        //1 . get veriyi okur ve kullanıcıya döndürür (bir nevi return)
        //2. set veriyi atama.   örn: üretimyılı=2010 diyip atarsak set dir
        // get ise bu degeri dçndüdür ve okur
        // 2010---get----return

        //properyler public olmak zorundadır


        public string Markaadi
        {
            get { return markaadi; }
            set { markaadi = value; }
        
        }

        public int Fiyat
        {
            get { return fiyat; }
            set
            {
                if (value>20 && value<50)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Pahalı ya yürü git...");
                }
            
            }

        }

        public int üretim
        {
            get { return üretimYılı; }

            set 
            {
                üretimYılı = value;
                if (üretimYılı>2019 && üretimYılı<2022)
                {
                    üretimYılı = value;
                }
                else
                {
                    Console.WriteLine("bu yıllar olmaz...");
                }
            
            }
        
        }



    }

}
