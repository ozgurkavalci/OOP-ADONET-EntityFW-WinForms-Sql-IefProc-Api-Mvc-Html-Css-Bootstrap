//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kitapçı
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            this.Sube = new HashSet<Sube>();
        }
    
        public int UrunID { get; set; }
        public string UrunTuru { get; set; }
        public string UrunKategori { get; set; }
        public string UrunAdi { get; set; }
        public int UrunCikisYili { get; set; }
        public string UrunYazarAdi { get; set; }
        public int UrunAdet { get; set; }
        public decimal UrunFiyat { get; set; }
        public int MusteriMusteriID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sube> Sube { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
