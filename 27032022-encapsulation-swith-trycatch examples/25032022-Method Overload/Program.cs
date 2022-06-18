using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25032022_Method_Overload
{
    class Program
    {


        //method overloading
        //method isimleri ayni fakat parametleri farklı metodlara denir


        static void Topla(int a)
        {

            Console.WriteLine(":degeri:"+a);
        
        
        
        
        }

        static void Topla(int z,int x)
        {

            int topla = z + x;
            Console.WriteLine("z ve x degerlerinin toplami:"+topla);
        
        
        
        }


        static void Topla(double c, double f)
        {

            double topla = c + f;
            Console.WriteLine("c v f nin toplamı:"+topla);
        
        
        
        }
        static void Main(string[] args)
        {
            //Topla(10.4, 47.6);
            //Topla(1, 5);
            //Topla(8);
            //Console.ReadLine();


            OkulSecimi();
        }


        //swtich case  --- ilkokuk,ortaokul,ise  
        // ortak metod kullanıcaz
        // ilkokulda alması gereken notlar --1.sınav,2.sınav
        //ortaokul  allması gerken notlar --- 1. sınav ,2.sınav ve sözlüsınav
        //lise  alması gereken notlar ---- 1. sınav 2 sınav ,sözlu sınav ve kanaat notu

        //ve tum hepsi ortalama hesaplayıp kaldı veya gectı yapacak.

        static void OkulSecimi()
        {

            Console.WriteLine("Okul ana menüye hosgeldiniz.");
            Console.WriteLine("Lütfen islem yapmak istediginiz öğretim türünü seçiniz:");
            Console.WriteLine("1-İlkokul");
            Console.WriteLine("2-Ortaokul");
            Console.WriteLine("3-Lise");
            int okultürü = Convert.ToInt32(Console.ReadLine());

            switch (okultürü)
            {
                case 1:
                    Console.WriteLine("Lütfen ilk sınav notunuzu giriniz:");
                    double sinav1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Lütfen ikinci sınav notunuzu giriniz:");
                    double sinav2 = Convert.ToDouble(Console.ReadLine());
                    not(sinav1, sinav2);
                    Console.ReadLine();


                    break;

                case 2:
                    Console.WriteLine("Lütfen ilk sınav notunuzu giriniz:");
                    double sinavor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Lütfen ikinci sınav notunuzu giriniz:");
                    double sinavor2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Lütfen sözlü sınav notunuzu giriniz:");
                    double sözlü = Convert.ToDouble(Console.ReadLine());
                    not(sinavor1, sinavor2, sözlü);
                    Console.ReadLine();

                    break;

                case 3:
                    Console.WriteLine("Lütfen ilk sınav notunuzu giriniz:");
                    double sinavlis1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Lütfen ikinci sınav notunuzu giriniz:");
                    double sinavlis2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Lütfen sözlü sınav notunuzu giriniz:");
                    double sözlülis = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Lütfen kanaat notunuzu giriniz:");
                    double kanaat = Convert.ToDouble(Console.ReadLine());
                    not(sinavlis1, sinavlis2, sözlülis, kanaat);
                    Console.ReadLine();

                    break;
                default:
                    break;
            }



        }

        static void not(double sinav1, double sinav2)
        {
            

            double toplam = sinav1 + sinav2;
            double ortalama = toplam / 2;

            if (ortalama>=45)
            {
                Console.WriteLine("Ortalamanız :"+ortalama+" tebrikler geçtiniz");
            }
            else
            {
                Console.WriteLine("Ortalamanız :" + ortalama + " ne yazık ki kaldınız");

            }
        
        }



        static void not(double sinav1, double sinav2,double sözlü)
        {
            double toplam = sinav1 + sinav2+sözlü;
            double ortalama = toplam / 3;

            if (ortalama >= 45)
            {
                Console.WriteLine("Ortalamanız :" + ortalama + " tebrikler geçtiniz");
            }
            else
            {
                Console.WriteLine("Ortalamanız :" + ortalama + " ne yazık ki kaldınız");

            }
            

        }


        static void not(double sinav1, double sinav2,double sözlü,double kanaat)
        {
            double toplam = sinav1 + sinav2+sözlü+kanaat;
            double ortalama = toplam / 4;

            if (ortalama >= 45)
            {
                Console.WriteLine("Ortalamanız :" + ortalama + " tebrikler geçtiniz");
            }
            else
            {
                Console.WriteLine("Ortalamanız :" + ortalama + " ne yazık ki kaldınız");

            }

        }

    }


}
