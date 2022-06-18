using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulasım_ornegi
{
    public class Program
    {
        static void Main(string[] args)
        {
            //koltuknumarası
            //koltuk konumu
            // bilet fiyatı
            //rezervasyon
            //durek bilgisi
            //durak adları
            // bilet fiyatı hesaplama metodu(fiyat , duraksayısı returnlu metod)

            //ulasımekstra(koltuk konum,rezervasyon) voidle method  konum guney se rezervasyon yapamaz

            // durek bilgisi cevizlibag ise seferimiz yoktur.



            Console.WriteLine("Ulasım hizmetleri anasayfasına hosgeldınız...");
            Console.WriteLine("a-Hava Yolları");
            Console.WriteLine("b-Kara Yolları");
            Console.WriteLine("c-Demir Yolları");
            Console.WriteLine("d-Deniz Yolları");
            Console.WriteLine("Lutfen bir secim yapınız.");
            string anamenüsecim = Console.ReadLine();
            switch (anamenüsecim)
            {
                case "a":

                    havayolları hava = new havayolları();
                    hava.Havayolları();



                    break;
                case "b":
                    karayolları kara = new karayolları();
                    kara.Karayollarıaltsayfa();
                    break;

                case "c":
                    
                    break;

                case "d":
                    
                    break;
                default:
                    break;
            }
            Console.ReadLine();



        }
    }
}
