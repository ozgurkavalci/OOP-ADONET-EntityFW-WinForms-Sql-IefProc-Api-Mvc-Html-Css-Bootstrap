using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kırtasiye
{
    internal class kagitmalzeme:Kırtasiye
    {   
        
        public string kagittürü;
        public int kagittopadeti;
        public int malzemebirimfiyati;


        
         

        public override int Kdv(int fiyat, string kagittürü)
        {
            if (kagittürü.ToLower() == "a3" || kagittürü.ToLower() == "a4")
            {
                fiyat *= 110 / 100;
                return fiyat;
            }
            else if (kagittürü.ToLower() == "a5" || kagittürü.ToLower() == "a6")
            {
                fiyat *= 112 / 100;
                return fiyat;
            
            }
            else
            {
                fiyat *= 108 / 100;
                return fiyat;
            }

        }


        public override void StokTakip(string kagıttürü, int stok)
        {
            Random rnd= new Random();
            stok=rnd.Next(3000,15000);

            if(stok>=9500)
            {
                if (kagittürü.ToLower() == "a3" || kagittürü.ToLower() == "a4")
                {

                    Console.WriteLine("Sectiginiz" + kagıttürü + "%10 zamlıdır.");

                }
                else if (kagittürü.ToLower() == "a5" || kagittürü.ToLower() == "a6")
                {

                    Console.WriteLine("Sectiginiz" + kagıttürü + "%12 zamlıdır.");

                }
                else
                {
                    Console.WriteLine("Sectıgınız kagittürü yüzde 8 zamlıdır.");

                }



            }
            else
            {

            }


            


        }
    }
}
