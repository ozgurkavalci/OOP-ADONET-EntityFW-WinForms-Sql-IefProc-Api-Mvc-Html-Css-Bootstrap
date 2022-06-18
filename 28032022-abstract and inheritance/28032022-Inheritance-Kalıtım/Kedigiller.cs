using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28032022_Inheritance_Kalıtım
{
    internal class Kedigiller:kosanhayvanlar
    {
        public int kilo;
        public string cins;
        public string üremezamani;

        public void Yonlendır(int kilo, string cins)
        {
            if (kilo>10 && kilo<20)
            {
                Console.WriteLine(cins+"kediler satılabilir.");
            }
            else
            {
                Console.WriteLine(cins+"kediler devlet korumasında alamazsınız.");
            }
        
        }
        
    }
}
