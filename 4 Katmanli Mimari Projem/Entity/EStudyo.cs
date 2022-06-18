using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EStudyo
    {
        private int _StudyoID;
        private string _StudyoAdi;
        private DateTime _StudyoKurulusTarih;
        private string _StudyoMerkez;
        private decimal _StudyoNetDeger;


        public int StudyoID
        { get { return _StudyoID; } set { _StudyoID = value; } }

        public string StudyoAdi
        { get { return _StudyoAdi; } set { _StudyoAdi = value; } } 

        public DateTime StudyoKurulusTarih
        { get { return _StudyoKurulusTarih; } set { _StudyoKurulusTarih = value; } }


        public string StudyoMerkez
        { get { return _StudyoMerkez; } set { _StudyoMerkez = value; } }


        public decimal StudyoNetDeger
        { get { return _StudyoNetDeger; } set { _StudyoNetDeger = value;} }

        






    }
}
