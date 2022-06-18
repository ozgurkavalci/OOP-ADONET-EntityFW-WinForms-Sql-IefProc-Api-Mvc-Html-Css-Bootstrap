using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_devam
{
    abstract class Gerecler
    {
        public int gerecno;
        public string gereckategori;
        public int fiyat;
        public int adet;

        public abstract int Fatura(int fiyat, int adet);
        public abstract void KategoriBelirle(string gereckategori);  




    }
}
