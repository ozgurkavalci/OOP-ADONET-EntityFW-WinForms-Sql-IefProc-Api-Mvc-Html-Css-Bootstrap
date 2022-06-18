using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_base_class_abstract_örnegi__CTOR_SONRASI_
{
    sealed class müstakil:ev
    {
        public double teklifegiden;

        public int hissepayi;
        public string parseladi;
        public int adano;

        public override void Teklifler(double fiyat)
        {
            Console.WriteLine("Asagıda secebileceğiniz opsyionlar verilmiştir.");
            Console.WriteLine("0-Özellik istemiyorum");
            Console.WriteLine("1-Bahce");
            Console.WriteLine("2-Ebeveyn banyosu");
            Console.WriteLine("3-Şömine");
            Console.WriteLine("Hangisini seçmek istersiniz lütfen tuşlayınız");
            int teklifsecim = Convert.ToInt32(Console.ReadLine());
            if (teklifsecim == 0)
            {
                Console.WriteLine("Özellik secmediginiz icin ödemeniz gerekn ücret:" + fiyat);
            }
            else if (teklifsecim == 1)
            {
                double bahceli = fiyat + 50000;
                Console.WriteLine("Bahce özelligi sectiginiz icin ödemeniz gereken ücret:" + bahceli);
            }
            else if (teklifsecim == 2)
            {
                double bahceli = fiyat + 30000;
                Console.WriteLine("Ebeveyn banyosu özelligini sectiginiz icin ödemeniz gereken ücret:" + bahceli);
            }
            else if (teklifsecim == 3)
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

        public void MustakilAnaEkran()
        {
            SoruEkranı();
            Console.WriteLine("Hisse payini giriniz:");
            hissepayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parsel adini giriniz:");
            parseladi = Console.ReadLine();
            Console.WriteLine("Ada no yu giriniz:");
            adano = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            MustakilCiktiEkrani();
            Console.WriteLine();
            Console.WriteLine("Mustakil ev " + odasayisi + " odası oldugu ıcın ve  " + m2 + "  metrakare oldugu icin zamlı fiyat:" + Evzam(odasayisi, m2, fiyat));
            teklifegiden = Evzam(odasayisi, m2, fiyat);
            Teklifler(teklifegiden);
            Console.WriteLine("Mustakil ev: arsa durumu:" + arsadurumu + " iskan durumu:" + iskandurumu + " oldugundan metrekare bası fiyati:" + Metrekarebasifiyat(arsadurumu, iskandurumu, m2, teklifegiden));



        }

        public void MustakilCiktiEkrani()
        {

            EkranCıktısıev();
            Console.WriteLine("Hisse payi:"+hissepayi);
            Console.WriteLine("Parsel adi:"+parseladi);
            Console.WriteLine("Ada no:"+adano);


        }

    }
}
