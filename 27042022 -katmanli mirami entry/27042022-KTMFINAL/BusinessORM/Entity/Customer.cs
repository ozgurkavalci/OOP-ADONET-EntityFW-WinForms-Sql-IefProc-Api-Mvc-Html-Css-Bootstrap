using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessORM.Entity
{
    public class Customer
    {
        public int MusteriNo { get; set; }
        public string MusteriAdSoyad { get; set; }
        public string MusteriCinsiyet { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusteriTcNo { get; set; }
        public string MusteriAdres { get; set; }
        public int MusteriHizmetNo { get; set; }
        public string MusteriMail { get; set; }

    }
}
