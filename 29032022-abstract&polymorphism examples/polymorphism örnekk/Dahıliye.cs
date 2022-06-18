using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnekk
{
    internal class Dahıliye : Hastane
    {
        public override int Fark(string sgk, int tahlil)
        {
            if (sgk.ToLower()=="var")
            {
                tahlil += tahlil * 5 / 100;
                return tahlil;
            }
            else
            {
                tahlil += tahlil * 25 / 100;
                return tahlil;
            }
        }

        public override void Hemsire()
        {
            Console.WriteLine("Dahiliye bashemsiresi Mine hanım");
        }

        public override int Ödeme(int katki, int ücret)
        {
            return base.Ödeme(katki, ücret);
        }

        public void yazdir()
        {
            VeriAl();
            Bas();
            Hemsire();
            Console.WriteLine("Ödemeniz gereken ücret:" + Ödeme(katkipayi, muayaneücreti));
            Console.WriteLine("Ödemeniz gerken fark:" + Fark(sgk,tahlil));



        }

    }
}
