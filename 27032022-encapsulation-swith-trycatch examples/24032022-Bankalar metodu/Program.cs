using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24032022_Bankalar_metodu
{
    class Program
    {
        static void Main(string[] args)
        {

            Anasayfa();
            Console.ReadLine();

        }

        static void Anasayfa()
        {   
            GotoAnasayfa:
            Console.WriteLine("BANKA SECINIZ");                                      
            Console.WriteLine("1-Garanti Bankası");
            Console.WriteLine("2-Ziraat Bankası");
            Console.WriteLine("3-İş Bankası");
            Console.WriteLine("Lutfen bir banka nosu tuslayınız.");
            int bankano = Convert.ToInt32(Console.ReadLine());
            switch (bankano)
            {

                case 1:
                    garantiBankası();
                    

                    break;

                case2:

                    break;

                    case3:


                    break;
                default:
                    break;
            }

        }


        static void garantiBankası()
        {
            Garantigo:
            Console.WriteLine("1-Bireysel Müşteri");
            Console.WriteLine("2-Kurumsal Müşteri");
            Console.WriteLine("Lutfen bir tercih yapınız:");
            int garantiBank = Convert.ToInt32(Console.ReadLine());
            if (garantiBank==1)
            {
                bireyselMusteriEkranı();



            }
            else if (garantiBank==2)
            {

                KurumsalMusteri();

            }
            else
            {
                Console.WriteLine("Geçerli bir tuşlama yapmadınız. Müşteri seçim ekranına yönlendiriliyorsunuz...");
                goto Garantigo;
            }
        
        }

        static void bireyselMusteriEkranı()
        {

            Plansecimekrani:
            Console.WriteLine("Ikı adet bireysel müşteri kredi opsiyonu bulunmaktadır.");
            Console.WriteLine("a-%10 faiz ile 3 tane krediyi 8 ay vade ile çekebilirsiniz.");
            Console.WriteLine("b-%20 faiz ile 2 tane krediyi 20 ay vade ile çekebilirsiniz");

            Console.WriteLine("Lutfen bir secim yapınız");
            string bireyselkredisecimi = Console.ReadLine();

            if (bireyselkredisecimi.ToLower()=="a")
            {

                Console.WriteLine("Lutfen ilk kredi miktarını giriniz:");
                double d1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Lutfen ikinci kredi miktarını giriniz:");
                double d2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Lutfen ucuncu kredi miktarını giriniz:");
                double d3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Aylık ödeme miktarin,z:"+bireyselkredio1(d1, d2, d3));
                if (IslemDevam() == true)
                {
                    Anasayfa();
                
                }
                else
                {
                    Environment.Exit(0);
                }

            }


            else if (bireyselkredisecimi.ToLower()=="b")
            {


                Console.WriteLine("Lutfen ilk kredi miktarını giriniz:");
                double d1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Lutfen ikinci kredi miktarını giriniz:");
                double d2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Aylık ödemeniz gereken miktar:"+bireyselkredio2(d1,d2));


                if (IslemDevam() == true)
                {
                    Anasayfa();

                }
                else
                {
                    Environment.Exit(0);
                }
            }

            else
            {
                Console.WriteLine("Gecerli bir plan seçmediniz.Plan seçim ekranına yönlendiriliyorsunuz...");
                goto Plansecimekrani;
            }
        
        }


        static double bireyselkredio1(double d1,double d2,double d3)
        {
            double sonuc = 0;

            

            d1 += d1 * 10 / 100;
            d2 += d2 * 10 / 100;
            d3 += d3 * 10 / 100;

            sonuc = (d1 + d2 + d3) / 8;



            return sonuc;
        }



        static double bireyselkredio2(double d1, double d2)
        {
            double sonuc = 0;

            

            

            d1 += d1 * 20 / 100;
            d2 += d2 * 20 / 100;
            

            sonuc = (d1 + d2 ) / 20;



            return sonuc;
        }


        static bool IslemDevam()
        {
            Console.WriteLine("İsleme devam etmek ister misiniz? <e/h>");
            string islemcevap = Console.ReadLine();
            if (islemcevap.ToLower() == "e")
            {
                return true;
            }

            else 
            {
                return false;
            }

            
        }


        static void KurumsalMusteri()
        {

            string kullanıcıAdı = string.Empty;
            string sifre = string.Empty;

            do
            {

                Console.Clear();
                Console.WriteLine("Lutfen kullanıcı adınızı giriniz:");
                kullanıcıAdı = Console.ReadLine();
                Console.WriteLine("Lutfen sıfrenızı gırınız:");
                sifre = Console.ReadLine();


                if (kullanıcıAdı == "demo" && sifre == "1234")
                {
                    Console.WriteLine("Lutfen faaliyet alanınızı giriniz:");
                    Console.WriteLine("1-Hizmet Sektörü");
                    Console.WriteLine("2-Sanayi Sektörü");

                    int faaliyetAlanı = Convert.ToInt32(Console.ReadLine());
                    if (faaliyetAlanı==1 || faaliyetAlanı==2)
                    {
                        sirketturusecimi:
                        Console.WriteLine("Lutfen sirket tipiniz seciniz:");
                        Console.WriteLine("1-Limited Şirketler");
                        Console.WriteLine("2-Anonim Şirketler");
                        Console.WriteLine("Lutfen bir secim yapınız:");
                        int sirketsecim = Convert.ToInt32(Console.ReadLine());
                        if (sirketsecim==1)
                        {
                            Console.WriteLine("Limited Şirketler için 2 tip kredi planı bulunmaktadır.");
                            Plantürü:
                            Console.WriteLine("1-Kredi 50000 Tl altında ise 68 ay ve %10 faiz+%3 masraf gideri.");

                            Console.WriteLine("2-Kredi 50000-100000 Tl arasında ise 72 ay vade %15 faiz+%7,5 masraf gideri.");

                            int limitedpaketsecimi = Convert.ToInt32(Console.ReadLine());

                            if (limitedpaketsecimi==1)
                            {
                                ellibinliraaltıgir:
                                Console.WriteLine("Lutfen 50000 Tl altınki kredi miktarını giriniz:");
                                double ellibinaltı = Convert.ToDouble(Console.ReadLine());

                                if (ellibinaltı<50000)
                                {
                                    
                                    Console.WriteLine("Ödemeniz gereken toplam ücret:" + limitedHesabı(ellibinaltı));

                                    if (IslemDevam() == true)
                                    {
                                        Anasayfa();

                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("50000 lira ustunde deger gırdınız.Lutfen gecerli bir degeri girin");
                                    goto ellibinliraaltıgir;

                                }
                                


                            }

                            else if (limitedpaketsecimi==2)
                            {

                                limitedHesabıvoid();

                                if (IslemDevam() == true)
                                {
                                    Anasayfa();

                                }
                                else
                                {
                                    Environment.Exit(0);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Geçerli bir seçim yapmadınız. Plan türü seçimine yönlendiriliyorsunuz.");
                                goto Plantürü;
                            }

                        }
                        else if (sirketsecim==2)
                        {

                        }

                        else
                        {
                            Console.WriteLine("Geçerli seçim yapmadınız .Şirket türü seçimini yönlendiriliyorsunuz...");
                            goto sirketturusecimi;
                        }
                        
                    }
                }


                Console.WriteLine("Hatalı giriş yaptınız Lütfen tekrar deneyin.");



            } while (kullanıcıAdı != "demo" &&  sifre != "1234");

        
        
        
        
        }





        static double limitedHesabı(double d1)
        {

            
            

            
            

                d1 += d1 * 10 / 100;
                d1 += d1 * 3 / 100;

                d1 = d1 * (68 / 12);

                return d1;

            
        }



        static void limitedHesabıvoid()
        {

            Console.WriteLine("Lutfen 50000-100000 Tl arasındaki kredi miktarını giriniz:");
            double ellibinyüzbin = Convert.ToDouble(Console.ReadLine());

            ellibinyüzbin += ellibinyüzbin*15 / 100;
            ellibinyüzbin += ellibinyüzbin * 7.5 / 100;
            double toplamödeme = ellibinyüzbin *72/12;
            double ayliködeme = toplamödeme /72 ;

            Console.WriteLine("Toplam ödenecek tutar:"+toplamödeme);
            Console.WriteLine("Aylık ödenecek tutuar:"+ayliködeme);




        }


        static void Ziraat()
        {   ziraatanamenü:
            Console.WriteLine("Ziraat Bankası Ana menuye hosgeldınız.");
            Console.WriteLine("1-İhtiyac Kredisi");
            Console.WriteLine("2-Konut Kredisi");
            int ziraatsecim = Convert.ToInt32(Console.ReadLine());
            if (ziraatsecim==1)
            {

                Ziraat();

            }
            else if (ziraatsecim==2)
            {

            }
            else
            {
                Console.WriteLine("Gecerli bir secim yapmadınız.Ziraat Bankası ana menuye geri yönlendiriliyorsunuz...");
                goto ziraatanamenü;
            }
        
        }



        static void ZirIhtiyac()
        {
            Console.WriteLine("İhtiyac kredisi ana ekranına hosgeldiniz.");
            Console.WriteLine("Kac ay vade istiyorsunuz?");
            double vade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Çekmek istediginiz meblayı giriniz:");
            double kredi = Convert.ToDouble(Console.ReadLine());
            double ayliködeme = (kredi * 02) / vade;
            for (int i = 0; i <= vade ; i++)
            {
                ayliködeme = ayliködeme * 1.02;
                Console.WriteLine(""+i+". ayın ödemesi:"+ayliködeme);
            }
        
        
        
        
        
        }


        static void ZırKonut()
        {

            Console.WriteLine("Konut Kredisi ana ekranına hosgeldiniz");
            Console.WriteLine("1- sıfır daire");
            Console.WriteLine("2-2. el daire");
            Console.WriteLine("Lutfen bir secim yapınız");
            int zirsecin = Convert.ToInt32(Console.ReadLine());

            if (zirsecin==1)
            {
                Console.WriteLine("İlce tercihleri asagidaki gibidir");
                Console.WriteLine("1-Kadıköy veya etiler ise ");
                Console.WriteLine("2-üsküdar veya şili ise ");
                Console.WriteLine("3-Diğer ilçeler için ");
                Console.WriteLine("Lutfen bir tercih yapınız:");

            }
            else if (zirsecin==2)
            {
                Console.WriteLine("Almak istediginiz konutun tutarını giriniz:");
            }

            else
            {
                Console.WriteLine("Gecerli bir seicm yapmadınız. İşlem sonlandırıyor");
                Environment.Exit(0);
            }
        
        
        }

    }



}
