using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim_Personel_Örnegi
{
    abstract class Personel
    {

        public int id;
        public string adsoyad;
        public double tcno;
        public string seans;
        public string mezuniyet;
        public int yas;
        public int ucret;
        public int devamsizliksayisi;
        public string statu;
        public int prim;




        public void PersonelSoruEKranı()
        {
            Console.WriteLine("Lutfen sirket id nizi giriniz:");
            id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen ad ve soyadınızı giriniz:");
            adsoyad=Console.ReadLine();
            Console.WriteLine("Lutfen tc nonuzu giriniz:");
            tcno=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Verimlilik arttirma amaciyla yapilan seanslara kayitli misiniz?(evet/hayir):");
            seans=Console.ReadLine();
            Console.WriteLine("Lutfen mezunıyet durumunuzu gırınız:");
            mezuniyet=Console.ReadLine();   
            Console.WriteLine("Lutfen yasınızı giriniz:");
            yas=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen ucret bilginizi giriniz:");
            ucret=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen devamsızlık  (ıse gelmedıgınız gun) sayıısnı gırınız:");
            devamsizliksayisi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen is yeri statu klasmaninizi  giriniz:(A,B,C,D)");
            statu=Console.ReadLine();
            //Console.WriteLine("Lutfen prim miktarınızı giriniz:");
            //prim=Convert.ToInt32(Console.ReadLine());

            

            
        
        
        
        }


        public abstract int SeansUcretihesapla(string seans, int ucret);

        public abstract void Primhesapla(string statü, int yas,string seans,int ucret);

        public virtual int Zamyap(string mezuniyet, int ucret)
        {

            //if (mezuniyet.ToLower() == "lisans")
            //{
            //    ucret = ucret * 125 / 100;

            //    return ucret;
            //}
            //else if (mezuniyet.ToLower() == "lise")
            //{
            //    ucret = ucret * 115 / 100;
            //    return ucret;


            //}
            //else
            //{
            //    ucret = ucret * 108 / 100;
            //    return ucret;
            //}
            return 1;
        }
        



    }
}
