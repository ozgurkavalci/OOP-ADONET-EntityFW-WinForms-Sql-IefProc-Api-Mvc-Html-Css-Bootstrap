using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnekk
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1-Dahiliye");
            Console.WriteLine("2-Kardiyoloji");
            Console.WriteLine("Bölüm seciniz:");

            int secim=Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Dahiliye bölümüne hosgeldinizç");
                    Dahıliye dahildir = new Dahıliye();
                    dahildir.yazdir();

                    break;

                    case 2:
                    break;

                default:
                    break;
            }



            Console.ReadLine();


            


        }
        
    }
}
