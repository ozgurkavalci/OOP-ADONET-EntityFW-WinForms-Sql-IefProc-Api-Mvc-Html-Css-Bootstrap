using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28032022_Abstract_Classlar
{
    abstract class Halı//Soyutlanmıs bır class oldu artık bu classtan nesene uretemem ancak yavru classlara kalıtım bırakarak uretebılır.
    {

        public string marka;
        public string model;
        public int fiyat;


        public abstract void Hesapla(string marka, int fiyat);

        public abstract int Indirim( int fiyat);

        public void Özellikler()
        {
            Console.WriteLine("Halılarımız cengizhan usta gaizantepten gelmektedir");
        
        
        
        }


    }
}
