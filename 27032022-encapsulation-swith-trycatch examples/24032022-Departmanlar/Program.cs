using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24032022_Departmanlar
{
    class Program
    {
                                          //3 metod calısan sayısı,mesai durumu +1
        
        
        static void Departmanlar()
        {
            int departmanno;


            do
            {

                Console.Clear();
                Console.WriteLine("************DEPARTMANLAR******************");
                Console.WriteLine("1-Muhasabe");
                Console.WriteLine("2-Teknik Servis");
                Console.WriteLine("3-İnsan Kaynakları");
                Console.WriteLine("4-Cıkıs");

                Console.WriteLine("Lutfen bir departman seciniz:");
                departmanno = Convert.ToInt32(Console.ReadLine());

                switch (departmanno)
                {
                    case 1:
                        Console.WriteLine("Aylık gelirinizi giriniz:");
                        int gelir = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Aylık giderinizi giriniz:");
                        int gider = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Calısan sayısınızı giriniz:");
                        int calısansayi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Bir çalısanın maliyetini giriniz");
                        int maliyet = Convert.ToInt32(Console.ReadLine());
                        Muhasabe(gelir, gider, calısansayi, maliyet);
                        int aysayisi = 12;
                        int pirim = 500;

                        if (prim()==true)
                        {
                            Console.WriteLine("Tebrikler prim kazandınız.");

                            Console.WriteLine("Yıllık prim miktarınız:" + primhesabı(calısansayi, pirim, aysayisi));

                        }

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    
                        
                }

            } while (departmanno!=4);
            Console.ReadLine();


        }

        static void Muhasabe(int gelir, int gider,int calisansayisi,int calisanmaliyeti)
        {

            Console.WriteLine("Firmanın yıllık kazancı:"+((gelir-gider)*12));
            Console.WriteLine("Total Calısan gideri:"+(calisansayisi*calisanmaliyeti*12));
        
        
        
        }



        static bool prim()
        {

            Console.WriteLine("Mesainizi var mı? <e/h>");
            string boolcevap = Console.ReadLine();
            if (boolcevap.ToLower()=="e")
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }



        static int primhesabı(int calisansayiyis, int prim, int yil)
        {
            int primsounucu = calisansayiyis * prim * yil;
            return primsounucu;
        
        }


        static void Main(string[] args)
        {

            Departmanlar();

        }
    }
}
