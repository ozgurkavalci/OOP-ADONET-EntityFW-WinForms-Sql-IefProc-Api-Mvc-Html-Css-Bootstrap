using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28032022_Inheritance_Kalıtım
{
    internal class Hayvan           // base yanı temel klas,super class
    {

        public string tip;             //----->field özellik
        public string nefesdurumu;
        public string renk;

        public void Petshop()
        {

            Console.WriteLine("Sadece evcil kediler satılabilir.");
            Console.WriteLine("Yırtıcı hayvanlar ıcın özel ızın gerekmektedir.");
        
        }

    }
}
