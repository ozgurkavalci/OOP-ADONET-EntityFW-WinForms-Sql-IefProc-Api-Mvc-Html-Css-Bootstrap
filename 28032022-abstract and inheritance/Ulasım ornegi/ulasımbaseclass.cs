using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulasım_ornegi
{
    public class ulasımbaseclass
    {
         

        public void ANASAYFA()
        {

            Console.WriteLine("Ulasım hizmetleri anasayfasına hosgeldınız...");
            Console.WriteLine("a-Hava Yolları");
            Console.WriteLine("b-Kara Yolları");
            Console.WriteLine("c-Demir Yolları");
            Console.WriteLine("d-Deniz Yolları");
            Console.WriteLine("Lutfen bir secim yapınız.");
            string anamenüsecim=Console.ReadLine();
            switch (anamenüsecim)
            {
                case "a":
                    
                    
                    

                    
                    break;
                    case "b":
                    
                    break;

                case "c":
                    
                    break;

                        case "d":
                    
                    break;
                default:
                    break;
            }



        }

        public double duraksayisi;
        private int koltuknumarası;
        private string koltukonum;
        private double biletfiyatı; //(dureka bası fıyat)
        private string rezervasyon;
        private string durakbilgisi;
        private string durakadları;

        public int Koltuknumarasi
        {
            get { return koltuknumarası; }

            set { koltuknumarası = value; }
        
        }
        public string Koltukkonum
        {
            get { return koltukonum; }
            set
            {
                if ("kuzey"==value.ToLower())
                {
                     koltukonum=value;
                }
                else if("güney"== value.ToLower())
                {
                    Console.WriteLine("Güney yonunde rezervasyon yapılamamaktadır.");
                }
                
            
            }
        
        }

        public double Biletfiyat
        {
            get { return biletfiyatı; }
            set { biletfiyatı = value; }
        }

        public string Rezervasyon
        {
            get { return rezervasyon; }
            set { rezervasyon= value; }
        
        }

        public string Durakbilgisi
        {
            get { return durakbilgisi; }
            set
            {
                if ("cevizlibag"==value.ToLower())
                {
                    Console.WriteLine("Cevizlibag durağına hizmet verilememektedir.");
                }

                else
                {
                    durakbilgisi=value; 
                }
            
            }

           
        }



        public string Durakadları
        {
            get { return durakadları; }
            set
            {
                durakadları=value;

            }


        }


        public double Fiyathesabı(double durakbasıfiyat, double durakadeti)
        {
            
            double fatura = Biletfiyat * durakadeti;

            return fatura;
        }


        public void Ulasımektra(int koltukno, string koltukkonumu)
        {

            Console.WriteLine(koltukno+" numaralı koltugunuz icin "+koltukkonumu+"konumunda satin alma islemi yapılmıstır.");
        
        
        }




        public void heryerdeaynı()
        {

            Console.WriteLine("Lutfen bir koltuk numarası giriniz:");
            Koltuknumarasi = Convert.ToInt32(Console.ReadLine());
                                                                                 //try and cathc calısmıyor cunku anasayfa metodunu ıcınde olmalıydı.
            gotokoltukkonumsecimi:
            Console.WriteLine("Lutfen bir koltuk konumu giriniz:");
            string koltukkonumuaraci=Console.ReadLine();
            if (koltukkonumuaraci.ToLower()=="guney")
            {
                Console.WriteLine("Guney kisminda koltuk bulunmamaktadir. Koltuk konum secimine yonlendiriliyorsunuz...");
                goto gotokoltukkonumsecimi;
            }
            else
            {
                Koltukkonum = koltukkonumuaraci.ToLower();
            }           
        
            Console.WriteLine("Durak bası fiyat giriniz:");
            Biletfiyat=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rezervasyonunuz var mı?:");
            
            Rezervasyon=Console.ReadLine();
            gotodurakguzergahi:
            Console.WriteLine("Gitmek istediğiniz durak guzergahini  giriniz(Cevizlibag veya digerleri olarak):");
            string durakbilgisiaraci=Console.ReadLine();
            if (durakbilgisiaraci.ToLower()=="cevizlibag")
            {
                Console.WriteLine("Cevizlibag yonunde bakim calismasi var. Lutfen baska bir secim yapiniz..");
                goto gotodurakguzergahi;    
            }
            else
            {
                Durakbilgisi=durakbilgisiaraci.ToLower();
            }
            
            Console.WriteLine("Durak adini giriniz");
            Durakadları=Console.ReadLine();
            Console.WriteLine("Kaç durak gitmek istiyorsunuz:");
            duraksayisi=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ödemeniz gerken ücret:"+Fiyathesabı(Biletfiyat, duraksayisi));
            Ulasımektra(Koltuknumarasi,Koltukkonum);





        }
    }
}
