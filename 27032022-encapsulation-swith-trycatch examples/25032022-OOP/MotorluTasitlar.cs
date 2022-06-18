using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25032022_OOP
{
    class MotorluTasitlar
    {
        //public
        // private 
        //Protected --Kalıtım ilgili durumdlarda kullanılır
        //Internal  --- Classlarin varsayılan degerleri internaldır.

        public int yakitfiyat;
        int yakitlitre;                   // bu  ortak ozellıkler field (alan ) olarak adlandırılır
        public string aracadi;            // her birinin bir erisim belirteci olmalıdır yoksa private atanır ve mainden goruntulenemez.
        string aracmark;
                        
        //private olan field alanlarına erişim için kapsülleme kullanacağız(encapsulation). Public propertyler oluşturacağız.
    }
}
