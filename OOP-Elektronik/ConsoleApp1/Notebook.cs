using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Notebook : Bilgisayarlar
    {
        private string ekrankartimarkasi;
        private string isletimsistemi;
        private double ssddurumu;

        public double ilkgelenzam;
        public double faturaicinegiden;
        
        public string Ekrankartimarkasi
        { 
            get { return ekrankartimarkasi; }
            set
            {
                if (value.ToLower()=="samsung")
                {
                    ekrankartimarkasi = value;
                }
                else
                {
                    Console.WriteLine("Sistem bilgisayariniza uygun bir ekran karti markasi tanimlayacaktir.");
                }
            
            }
        
        }


        public string Isletimsistemi
        {
            get { return isletimsistemi; }
            set
            {
                if (value.ToLower() == "linux")
                {
                    isletimsistemi = value;
                }
                else
                {
                    Console.WriteLine("Sistem bilgisayariniza uygun bir isletim sistemini size tanimlayacaktir.");
                }

            }

        }


        public double Ssddurumu
        {
            get { return ssddurumu; }
            set 
            {
                if (value==2048)
                {
                    ssddurumu = value;
                }
                else
                {
                    Console.WriteLine("Sistem bilgisayariniza uygun boyutta bir ssd disk size tanimlayacaktir.");
                }
            }
        
        }


        public Notebook()
        {
            ekrankartimarkasi = "nvidia";
            isletimsistemi = "windows";
            ssddurumu = 512;
        }

        public void notebookanamenu()
        {
            bilgisayarAnaMenu();
            Console.WriteLine("Lutfen ekran karti markasini giriniz:");
            Ekrankartimarkasi=Console.ReadLine();
            Console.WriteLine("Lutfen isletim sistemini giriniz:");
            Isletimsistemi=Console.ReadLine();
            Console.WriteLine("Lutfen ssd disk boyutunu giriniz:");
            Ssddurumu=Convert.ToDouble(Console.ReadLine());
            Kampanya(uretimyili, marka);
            Console.WriteLine();
            Console.Clear();
            ElektronikAnaMenuCikti();
            Console.WriteLine();
            Console.WriteLine("Sectiginiz urunun ekran karti markasi:"+ekrankartimarkasi);
            Console.WriteLine("Sectiginiz urunun isletim sistemi:"+isletimsistemi);
            Console.WriteLine("Sectiginiz urunun ssd hard disk boyutu:"+ssddurumu);
            Console.WriteLine();

            
            ElektronikZamIndirimCikti();
            B_Fatura(harddiskboyutu, islemciadi,ilkindirimsonrasi,kdv);




        }

        public override void B_Fatura(double harddiskboyutu, string islemciadi, double fiyat, double kdv)
        {
            if (harddiskboyutu>=1024 && islemciadi.ToLower()=="intel" || islemciadi.ToLower() == "amd")
            {
                fiyat += (fiyat * (kdv / 100) + 2500);
                Console.WriteLine(islemciadi+" markali ve "+harddiskboyutu+" hard disk boyutu olan parcalarin fiyati:"+fiyat);
            }
            else
            {
                
                fiyat += (fiyat * (kdv / 100) + 1500);
                Console.WriteLine(islemciadi + " markali ve " + harddiskboyutu + " hard disk boyutu olan parcalarin fiyati:" + fiyat);
            }
        }

        public override void Hesaplama(double fiyat, double kdv, double otv)       //KULLANMADIM METODU ZATEN YUKARDA FATURA VAR
        {
            fiyat += fiyat * (otv / 100);
            fiyat += fiyat * (kdv / 100);
            Console.WriteLine("Urununuzun kdv ve otv eklendikten sonraki fiyati:" + fiyat);
        }

        public override void Kampanya(int uretimyili, string marka)
        {
            if (uretimyili <= 2018 && marka.ToLower() == "toshiba" || marka.ToLower() == "asus")
            {
                Console.WriteLine("Bu urunlerde yuzde 20 ye varan kampanya mevcut");
            }
            else
            {
                Console.WriteLine("Firsatlari kesfetmek icin alisverise devam edin...");
            }
        }

        public override double Zam(double fiyat)
        {
            if (fiyat <= 1000)
            {
                fiyat = fiyat * 105 / 100;
                return fiyat;
            }

            else
            {
                fiyat =fiyat* 110 / 100;
                return fiyat;
            }



            //return base.Zam(fiyat);
        }
        public override double Indirim(double fiyat)
        {
            if (fiyat <= 500)
            {
                fiyat = fiyat*97 / 100;
                return fiyat;
            }
            else if (fiyat > 500 && fiyat <= 1000)
            {
                fiyat = fiyat*95 / 100;
                return fiyat;
            }
            else
            {
                fiyat = fiyat * 92 / 100;
                return fiyat;
            }



            //return base.Indirim(fiyat);
        }
    }
}
