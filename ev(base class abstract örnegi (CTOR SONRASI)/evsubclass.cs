using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_base_class_abstract_örnegi__CTOR_SONRASI_
{
    internal class evsubclass : ev   //evsubclass =daire 
    {
        public string cephe;
        public string dairedurumu; //(site , ya da değil)
        public int katsayisı;
        public int balkonsayisi;
        public int banyosayisi;
        public double teklifegiden;  // bu degiskeni ben ekledim tum subclasslarda var//

        public void AylikOdeme(string cephe, int banyosayisi, string dairedurumu)
        {
            if (cephe.ToLower() == "güney" && banyosayisi >= 3)
            {
                int yilliködeme = (aidat + yoneticiucret) * 12;

                Console.WriteLine("Ödemeniz gereken yıllık aidat ve yönetici ücret toplamı:" + yilliködeme);
            }
            else if (cephe.ToLower() == "kuzey" || dairedurumu.ToLower() == "site")
            {
                int teknikbs = 50;
                int totalödemeaylik = teknikbs + aidat + yoneticiucret;
                int totalödemeyıllık = (teknikbs + aidat + yoneticiucret )* 12;

                Console.WriteLine("Aylık teknik bakım servis ücerti,aidat, yöneyici ücreti ödemeniz:"+totalödemeaylik);
                Console.WriteLine("Yıllık teknik bakım servis ücerti,aidat, yöneyici ücreti ödemeniz:"+totalödemeyıllık);
            
            
            
            }
        
        
        
        }




        public void evsubAnaMenu()
        {

            SoruEkranı();
            Console.WriteLine("Daire cephesini giriniz:");
            cephe=Console.ReadLine();

            Console.WriteLine("Bina daire durumunu giriniz:(site veya site dışı)");
            dairedurumu=Console.ReadLine();

            Console.WriteLine("Katsayisini giriniz:");
            katsayisı=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Balkon sayısını griniz:");
            balkonsayisi=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Banyo sayısını giriniz:");
            banyosayisi=Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            EkranCikti();
            Console.WriteLine();
            Console.WriteLine(  "Evin"+odasayisi+" odası oldugu ıcın ve  "+m2+" metrakare oldugu icin zamlı fiyat:"+ Evzam(odasayisi, m2, fiyat));
            
            teklifegiden = Evzam(odasayisi, m2, fiyat);
            Teklifler(teklifegiden);  // aslinda bu degeri metrekarebasina gondersek iyi olurdu ama metod void donuyor.

            Console.WriteLine("Evin: arsa durumu:" + arsadurumu + "iskan durumu:" + iskandurumu + "oldugundan metrekare bası fiyati:" + Metrekarebasifiyat(arsadurumu, iskandurumu, m2, teklifegiden));
            AylikOdeme(cephe, banyosayisi, dairedurumu);


        }


        public void EkranCikti()
        {

            EkranCıktısıev();

            Console.WriteLine("Daire cephesi:"+ cephe);
            
            Console.WriteLine("Bina daire durumu:"+dairedurumu);

            Console.WriteLine("Katsayisi:" + katsayisı);
            
            Console.WriteLine("Balkon sayısı:"+ balkonsayisi);
            
            Console.WriteLine("Banyo sayısı:"+banyosayisi);
          
        }

        public override double Evzam(int odasayisi, double m2, double fiyat)
        {
            return base.Evzam(odasayisi, m2, fiyat);
        }


        public override void Teklifler(double fiyat)
        {
            Console.WriteLine("Asagıda secebileceğiniz opsyionlar verilmiştir.");
            Console.WriteLine("0-Özellik istemiyorum");
            Console.WriteLine("1-Bahce");
            Console.WriteLine("2-Ebeveyn banyosu");
            Console.WriteLine("3-Şömine");
            Console.WriteLine("Hangisini seçmek istersiniz lütfen tuşlayınız");
            int teklifsecim = Convert.ToInt32(Console.ReadLine());
            if (teklifsecim==0)
            {
                Console.WriteLine("Özellik secmediginiz icin ödemeniz gerekn ücret:"+ fiyat);
            }
            else if (teklifsecim==1)
            {
                double bahceli = fiyat + 50000;
                Console.WriteLine("Bahce özelligi sectiginiz icin ödemeniz gereken ücret:"+bahceli);
            }
            else if (teklifsecim==2)
            {
                double bahceli = fiyat + 30000;
                Console.WriteLine("Ebeveyn banyosu özelligi sectiginiz icin ödemeniz gereken ücret:" + bahceli);
            }
            else if (teklifsecim==3)
            {
                double bahceli = fiyat + 15000;
                Console.WriteLine("Somine özelligi sectiginiz icin ödemeniz gereken ücret:" + bahceli);
            }
            else
            {
                Console.WriteLine("Gecersiz tuslama yaptınız. Sistemden çıkılıyor");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);    
            }
        }
    }
}
