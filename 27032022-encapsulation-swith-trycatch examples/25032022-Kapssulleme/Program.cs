using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25032022_Kapssulleme
{
    class Program
    {
        static void Main(string[] args)
        {

            Kolomyalar k1 = new Kolomyalar();
            k1.Markaadi = "Eyüp sabri Tuncer";


            k1.Fiyat = 60;
            k1.üretim = 2021;
            Console.WriteLine("Marka adı:"+k1.Markaadi);
            Console.WriteLine("Fiyat:"+k1.Fiyat);
            Console.ReadLine();
        }
    }
}
