using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24032022_yiyecek_icecek
{
    class Program
    {
        static int fatura;



        static void yiyecek(int ye)
        {

            if (ye==1)
            {
                Console.WriteLine("Et yemegi fiyatı"+35);
                fatura += 35;
            }
            else if (ye==2)
            {
                Console.WriteLine("Mantı fiyatı"+25);
                fatura += 25;
            }
            else if (ye==3)
            {
                Console.WriteLine("Tavuk yemegı fiyatı"+20);
                fatura += 20;     
            }
            
        
        }

        static void icecek(int ic)
        {

            if (ic == 1)
            {

                Console.WriteLine("Ayran fiyatı: " + 7);
                fatura += 7;
            }

            else if (ic == 2)
            {

                Console.WriteLine("Kola  fiyatı: " + 10);
                fatura += 10;
            
            }

            else if (ic==3)
            {
                Console.WriteLine("Limonata  fiyatı: " + 15);
                fatura += 15;
            }



        }


        static void tatlı(int tatli)
        {
            if (tatli==1)
            {
                Console.WriteLine("Kazandibi fiyat: "+15);
                fatura += 15;
            }

            else if (tatli==2)
            {
                Console.WriteLine("Tiramisu fiyatı: "+20);
                fatura += 20;
            }

            else if (tatli==3)
            {
                Console.WriteLine("Yas pasta fiyatı: "+35);
                fatura += 35;
            }
             



        }












        static void AnaMenu()
        {
            int ilktercih;



            do
            {
                Console.WriteLine("*******MENÜ**********");
                Console.WriteLine("1-Yiyecek");
                Console.WriteLine("2-İçecek");
                Console.WriteLine("3-Tatlı");
                Console.WriteLine("4-Hesap Ödeme");

                Console.WriteLine("Lütfen bir terchih yapınız");
                ilktercih = Convert.ToInt32(Console.ReadLine());

                switch (ilktercih)
                {
                    case 1:
                        Console.WriteLine("1- Et yemegi");
                        Console.WriteLine("2-Mantı");
                        Console.WriteLine("3-Tavuk");
                        Console.WriteLine("Lutfen bir yemek seciniz");
                        int yemeksec = Convert.ToInt32(Console.ReadLine());

                        yiyecek(yemeksec);

                        break;

                    case 2:
                        Console.WriteLine("1-Ayran");
                        Console.WriteLine("2-Kola");
                        Console.WriteLine("3-limonata");
                        Console.WriteLine("Lutfen bir icecek seciniz");
                        int iceceksec = Convert.ToInt32(Console.ReadLine());

                        icecek(iceceksec);
                        break;


                    case 3:

                        Console.WriteLine("1-Kazandibi");
                        Console.WriteLine("2-Tiramisu");
                        Console.WriteLine("3-Yas pasta");
                        Console.WriteLine("Lutfen bir tatlı seciniz");
                        int tatlisec = Convert.ToInt32(Console.ReadLine());

                        tatlı(tatlisec);
                        break;

                    case 4:
                        FaturaOde();
                        break;


                    
                }



            } while (ilktercih!=4);

            Console.ReadLine();
        
        
        
        }




        static void FaturaOde()
        {
            Console.WriteLine("Ödemeneniz gereken tutar:"+fatura);
        
        }

        static void Main(string[] args)
        {
            AnaMenu();
        }
    }
}
