using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessORM.Entity
{
    public class Service
    {
        public int HizmetNo { get; set; }
        public string HizmetAdi { get; set; }
        public string HizmetTanimi { get; set; }
        public decimal HizmetFiyat { get; set; }

    }
}
