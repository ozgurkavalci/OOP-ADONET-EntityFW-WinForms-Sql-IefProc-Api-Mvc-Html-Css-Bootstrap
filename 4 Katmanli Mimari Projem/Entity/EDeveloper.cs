using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EDeveloper
    {
        private int _DeveloperID;
        private string _AdSoyad;
        private int _Yas;
        private string _Cinsiyet;
        private string _Ulke;
        private DateTime _IseBaslamaTarihi;
        private string _UzmanlikAlani;
        private int _MerkezID;

        public int DeveloperID
        {get { return _DeveloperID; } set { _DeveloperID = value; } }

        public string AdSoyad { get { return _AdSoyad; } set { _AdSoyad = value; } }

        public int Yas { get { return _Yas; } set { _Yas = value; } }

        public string Cinsiyet { get { return _Cinsiyet; } set { _Cinsiyet = value; } }  

        public string Ulke { get { return _Ulke; } set { _Ulke = value;} }

        public DateTime IseBaslamaTarihi
        { get { return _IseBaslamaTarihi; } set { _IseBaslamaTarihi = value; } }

        public string UzmanlikAlani
        { get { return _UzmanlikAlani; } set { _UzmanlikAlani = value; } }

        public int MerkezID
        { get { return _MerkezID; } set { _MerkezID = value;} }



        

    }
}
