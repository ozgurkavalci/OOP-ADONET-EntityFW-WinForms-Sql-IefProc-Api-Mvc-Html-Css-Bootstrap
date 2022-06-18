using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kırtasiye
{
    internal class Kagitdisi : Kırtasiye
    {
        public string malzemetürü;
        public int malzemeadeti;
        public int birimfiyat;



        public override int Kdv(int fiyat, string malzemeadi)
        {
            if (malzemeadi.ToLower() == "kalem" || malzemeadi.ToLower() == "silgi" || malzemeadi.ToLower() == "uc")
            {
                fiyat *=  105 / 100;
                return fiyat;
            }
            else if (malzemeadi.ToLower() == "defter" || malzemeadi.ToLower() == "kitap" || malzemeadi.ToLower() == "ders kitabı")
            {

                fiyat *= 110 / 100;
                return fiyat;
            
            }
            else if (malzemeadi.ToLower() == "boyama kitabı" || malzemeadi.ToLower() == "resim defteri")
            {
                fiyat *= 108 / 100;
                return fiyat;
            }
            else if (malzemeadi.ToLower() == "pastel boya" || malzemeadi.ToLower() == "sulu boya" || malzemeadi.ToLower() == "cizim kalemi")
            {
                fiyat *= 112 / 100;
                return fiyat;

            }
            else
            {
                fiyat *= 103 / 100;
                return fiyat;
            }
        }

        

        public override void StokTakip(string malzemeadi, int stok)
        {
            Random rnd=new Random();
            stok=rnd.Next(100,3000);

            if (malzemeadi.ToLower() == "kalem" || malzemeadi.ToLower() == "silgi" || malzemeadi.ToLower() == "uc")
            {
                Console.WriteLine("Sectiginiz "+malzemeadi+"urununun stok durumu:"+stok+" oldugundan yüzde 5 zamlıdır. ");
            
            }
            else if(malzemeadi.ToLower() == "defter" || malzemeadi.ToLower() == "kitap" || malzemeadi.ToLower() == "ders kitabı")
            {
                Console.WriteLine("Sectiginiz " + malzemeadi + "urununun stok durumu:" + stok + " oldugundan yüzde 10 zamlıdır. ");

            }
            else if (malzemeadi.ToLower() == "boyama kitabı" || malzemeadi.ToLower() == "resim defteri")
            {
                Console.WriteLine("Sectiginiz " + malzemeadi + "urununun stok durumu:" + stok + " oldugundan yüzde 8 zamlıdır. ");
            }
            else if (malzemeadi.ToLower() == "pastel boya" || malzemeadi.ToLower() == "sulu boya" || malzemeadi.ToLower() == "cizim kalemi")
            {
                Console.WriteLine("Sectiginiz " + malzemeadi + "urununun stok durumu:" + stok + " oldugundan yüzde 12 zamlıdır. ");
            }
            else
            {
                Console.WriteLine("Sectiginiz " + malzemeadi + "urununun stok durumu:" + stok + " oldugundan yüzde 3 zamlıdır. ");
            }


        }



    }
}
