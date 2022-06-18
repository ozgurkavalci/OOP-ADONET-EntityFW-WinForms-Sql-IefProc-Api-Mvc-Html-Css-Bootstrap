using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_base_class_abstract_örnegi__CTOR_SONRASI_
{
    internal class villa:ev
    {
        public double teklifegiden;
        private string villaadi;
        private string villatipi;
        private string otoparkdurum;
        private int bahcem2;







        public void VİllaAnaMenu()
        {
            SoruEkranı();
            Console.WriteLine("Villa adını giriniz:");
            Villaadi=Console.ReadLine();
            Console.WriteLine("Villa tipini giriniz:");
            Villatipi=Console.ReadLine();
            Console.WriteLine("Otopark durumunu giriniz:");
            Otoparkdurum=Console.ReadLine();
            Console.WriteLine("2. bahce sayısını gırınız:");
            Bahcem2=Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            VillEkranCikti();
            Console.WriteLine();
            Console.WriteLine("Villa nın " + odasayisi + " odası oldugu ıcın ve  " + m2 + " metrakare oldugu icin zamlı fiyat:" + Evzam(odasayisi, m2, fiyat));
            teklifegiden = Evzam(odasayisi, m2, fiyat);
            Teklifler(teklifegiden);
            Console.WriteLine("Villanin: arsa durumu:" + arsadurumu + " iskan durumu:" + iskandurumu + " oldugundan metrekare bası fiyati:" + Metrekarebasifiyat(arsadurumu, iskandurumu, m2, teklifegiden));

            



        }

        public void VillEkranCikti()
        {

            EkranCıktısıev();
            Console.WriteLine("Villa adı:"+villaadi);
            Console.WriteLine("Villa tipi:"+villatipi);
            Console.WriteLine("Otopark durumu:"+otoparkdurum);
            Console.WriteLine("2. bahce sayısı:"+bahcem2);
       
           
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
                Console.WriteLine("Ebeveyn banyosu özelligi sectiginiz icin ödemeniz gereken ücret:" + bahceli);
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

        

       

        public villa()
        {
            villaadi = " yesilvadi";
            villatipi = "Tripleks boğaza nazır";
            otoparkdurum = "5 arac kapasiteli";
            bahcem2 = 3;

        }

        public string Villaadi
        {  get { return villaadi; } 
            set 
            {
                if (value=="acarkent")
                {
                    villaadi = value;
                }
                else
                {
                    Console.WriteLine("Sistem size bir villa adı atayacak");
                }
            
            }
        }
        public string Villatipi
        { 
          get { return villatipi; }

            set 
            {
                if (value=="dubleks")
                {
                    villatipi=value;
                }
                else
                {
                    Console.WriteLine("Sistem size uygun bir villa tipi atayacaktır.");
                }
            
            
            }
        
        
        }
        
        public string Otoparkdurum
        {
            get { return otoparkdurum; }
            set
            {
                if (otoparkdurum=="4 arac kapasiteli")
                {
                    otoparkdurum = value;
                }
                else
                {
                    Console.WriteLine("Sistem size uygun bir otopark türü tanımlayacaktır.");
                }
            }
        
        }
        
        public int Bahcem2
        {
            get { return bahcem2; }
            set 
            {
                if (value==4)
                {
                    bahcem2 = value;
                }
                else
                {
                    Console.WriteLine("Villanıza uygun ikinci bahce adeti sistem tarafından tanımlanmıstır.");
                }
            }
        
        
        
        }

    }
}
