using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7042022_
{
    internal class Musteriler : IKaydet,IGetir
    {

        private int mno;
        private string madsoyad;
        private string telefon;
        private string mail;
        private string adres;
        private int limit;
        private int odeme;


        public int Mno
        { 
        
         get { return mno; }
            set { mno = value; }
        
        }

        public string Madsoyad
        {
            get { return madsoyad;} 
            set { madsoyad = value; }   

        }

        public string Telefon
        { 
        
           get { return telefon;}   
            set { telefon = value; }
        
        }

        public string Mail
        { 
           get { return mail;}  
            set { mail = value; }

        
        
        }

        public string Adres
        { 
          get { return adres;}  
            set { adres = value; }      

        }

        public int Limit
        { 
          get { return limit;}  
            set { limit = value; }
        }

        public int Odeme
        { 
          get { return odeme; }
            set { odeme = value; }
        
        }

        public int Kampanya(int limit)
        {
            if (limit > 100 && limit < 1000)
            {
                limit += limit * 10 / 100;
                return limit;
            }
            else
            {
                limit += limit * 15 / 100;
                return limit;
            }

        }

        public string Konum(int odeme, string adres)
        {
            if (odeme>2000)
            {
                return adres;
            }
            else
            {
                return "ankara";
            }
        }

        public int Tutar(int limit, int odeme)
        {
            if (limit > 100 && limit < 1000)
            {
                odeme -= odeme * 5 / 100;
                return odeme;
            }
            else
            {
                odeme -= odeme * 25 / 100;
                return odeme;
            }
        }
    }
}
