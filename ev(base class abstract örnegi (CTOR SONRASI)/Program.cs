using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_base_class_abstract_örnegi__CTOR_SONRASI_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ev tipleri asagıdaki gibidir.");
            Console.WriteLine("1-Daire");
            Console.WriteLine("2-Villa");
            Console.WriteLine("3-Müstakil");
           /* Console.WriteLine("4-Dubleks");*/ // 'ptal oldu
            Console.WriteLine("Lutfen bir secim yapınız:");
            int evtipisecim = Convert.ToInt32(Console.ReadLine());
            switch (evtipisecim)
            {
                case 1: 
                    evsubclass  daire= new evsubclass();
                    daire.evsubAnaMenu();
                    
                    break;

                case 2:
                    villa villa= new villa();   
                    villa.VİllaAnaMenu();
                    break;
                case 3:
                    müstakil müstakil=new müstakil();
                    müstakil.MustakilAnaEkran();
                    break;
                                  
                   default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
