using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25032022_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //nesne üretme  bellekte Heap kısmında bulunur bu nedenle(reference type denir)         stack olanlar ise deger tipli

            MotorluTasitlar m1 = new MotorluTasitlar();
            m1.aracadi = "Kamyon";
            m1.yakitfiyat = 22;
            Console.WriteLine("Arac Turu:"+m1.aracadi);
            Console.WriteLine("Yakıt fiyatı:"+m1.yakitfiyat);
            Console.ReadLine();

        }
    }
}
