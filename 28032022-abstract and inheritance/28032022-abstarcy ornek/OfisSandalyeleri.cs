using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28032022_abstarcy_ornek
{
    internal class OfisSandalyeleri : sandalye
    {
        public override void KdvHesapla(int fiyat)
        {
            if (fiyat>1000)
            {
                fiyat += fiyat * 10 / 100;
            }
        }

        public override int ZamYap(string model, int fiyat)
        {
            if (model=="alaturka")
            {
                fiyat += fiyat * 50 / 100;
                return fiyat;
            }
            return fiyat;
        }
    }
}
