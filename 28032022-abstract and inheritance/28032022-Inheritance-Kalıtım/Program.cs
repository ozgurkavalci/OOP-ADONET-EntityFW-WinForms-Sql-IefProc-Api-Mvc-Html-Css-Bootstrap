using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28032022_Inheritance_Kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOp temel ilkeler
            //1)Kapsülleme done
            //2)Kalıtım
            //3)Abstract
            //4)Polimorfizim

            //ek ozelliler constructor,sealed...


            ///KALITIM
            ///ORNEK



            //Kosan hayvanlar class ını hayvanlar klass ına bagladık
            // daha sonra kedıler klass ına kosan hayvanlar atadık ve multı level kalıtımla hayvanlar ve kosan hayvanlar klass ındakı her seyı kedıler klass ına cektık.


            Kedigiller kedi1=new Kedigiller();
            kedi1.nefesdurumu = "akciger solunumu";
            kedi1.renk = "beyaz";
            kedi1.kilo = 16;
            kedi1.cins = "kaplan";
            kedi1.üremezamani = "mart";
            kedi1.kmsaat = 2;
            kedi1.kosmahizi = 100;

            kedi1.Petshop();
            kedi1.Yonlendır(kedi1.kilo, kedi1.cins);
            Console.ReadLine(); 


        }
    }
}
