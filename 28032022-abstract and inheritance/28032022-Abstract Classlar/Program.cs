using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28032022_Abstract_Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Absttact Classlar
            //SOYUTLAMA

            // Soyut sınıflar kalıtım özelliğini kullnarak kod tekrarını azaltırç
            // Soyut sınıflar kendisinden türeyen sınıflardır.Bu SInıflardan nesne OLUSTURAMAYIZ.
            // ANcak kalıtım bıraktıgımız yavru klasslardan nesne olusturarark erısım saglayabılırız.
            //Abstract klassların icerisinde abstract metodlar kullanabiliriz.
            //Soyut  sınıfı extend eden sınıf soyut sınıfın tüm soyut metodlarını override  etmek zroundadır.

            // Soyut sınıflar neden kullanılır:
            /*Soyut sınıfların ıcerısınde soyut metodların gövdesinin boş olması gerekir.Fakat diğer metodların gövdeleri olmak zroundadır.Bunun sebebi ise 
             * kullanılacak yere göre islem farklılıgı olacagından dolayı soyut sınıflar private olarak TANIMLANAMAZLAR.Çünkü kalıtım özelliğini her daim göstermek zorundadır.
             * 
             * 
             * 
             * 
             * 
             */

            Elhalısı deneme = new Elhalısı();
            deneme.Özellikler();
            Console.ReadLine();
        }
    }
}
