using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kırtasiye
{
    abstract class Kırtasiye
    {
        public int kirtasiyeno;
        public string kirtasiyeadi;


        public int stok;
        public int malzemeadet;
        public int fiyat;
        public string malzeadi;


        public abstract void StokTakip(string malzemeadi, int stok);

        public abstract int Kdv(int fiyat, string malzemeadi);

        public bool Kırtasiyesorgula(string kirtasiyeadi)
        {
            if (kirtasiyeadi.ToLower()=="köseoglu")
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }



    }
}
