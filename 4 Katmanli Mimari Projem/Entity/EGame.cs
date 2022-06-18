using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class EGame
    {
        private int _OyunID;
        private string _OyunTuru;
        private string _OyunAdi;
        private DateTime _OyunCikisTarihi;
        private int _OyunSatilanKopya;
        private string _AdSoyad;
        private string _StudyoAdi;

        public int OyunID
        { get { return _OyunID; } set { _OyunID = value; } }

        public string OyunTuru { get { return _OyunTuru; } set { _OyunTuru = value; } }

        public string OyunAdi { get { return _OyunAdi; } set { _OyunAdi = value; } }

        public DateTime OyunCikisTarihi
        { get { return _OyunCikisTarihi; } set { _OyunCikisTarihi = value; } }

        public int OyunSatilanKopya
        { get { return _OyunSatilanKopya; } set { _OyunSatilanKopya = value; } }    

        public string AdSoyad
        { get { return _AdSoyad; } set { _AdSoyad = value; } }

        public string StudyoAdi
        { get { return _StudyoAdi; } set { _StudyoAdi = value;} }


    }
}
