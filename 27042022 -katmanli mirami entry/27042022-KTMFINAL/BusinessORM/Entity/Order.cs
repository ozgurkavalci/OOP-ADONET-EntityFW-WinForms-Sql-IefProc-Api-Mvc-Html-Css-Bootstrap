using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessORM.Entity
{
    public class Order
    {
        public int SiparisNo { get; set; }
        public string SiparisAdi { get; set; }
        public int SiparisMusteriNo { get; set; }
        public string SiparisAdres { get; set; }
        public string SiparisAciklama { get; set; }

    }
}
