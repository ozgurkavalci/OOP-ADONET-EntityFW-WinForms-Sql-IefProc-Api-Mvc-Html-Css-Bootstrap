using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EMerkez
    {
        private int _MerkezID;
        private string _MerkezLokasyon;
        private DateTime _MerkezKurulusTarihi;
        private int _MerkezCalisanSayisi;
        private decimal _MerkezYillikCiro;
        private int _StudyoID;
        private string _StudyoAdi;


        public int MerkezID
        { get { return _MerkezID; } set { _MerkezID = value; } }

        public string MerkezLokasyon
        { get { return _MerkezLokasyon; }set { _MerkezLokasyon = value; } }

        public DateTime MerkezKurulusTarihi
        { get { return _MerkezKurulusTarihi; } set { _MerkezKurulusTarihi = value; } }  

        public int MerkezCalisanSayisi
        { get { return _MerkezCalisanSayisi; } set { _MerkezCalisanSayisi = value; } }

        public decimal MerkezYillikCiro
        { get { return _MerkezYillikCiro; } set { _MerkezYillikCiro = value; } }

        public int StudyoID
        { get { return _StudyoID; } set { _StudyoID = value; } }

        public string StudyoAdi
        { get { return _StudyoAdi; } set { _StudyoAdi = value;} }

    }
}
