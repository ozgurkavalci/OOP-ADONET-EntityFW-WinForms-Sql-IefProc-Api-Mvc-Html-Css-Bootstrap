//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _25042022_İefprocServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteriler()
        {
            this.Siparislers = new HashSet<Siparisler>();
        }
    
        public int MusteriNo { get; set; }
        public string MusteriAdSoyad { get; set; }
        public string MusteriCinsiyet { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusteriTcNo { get; set; }
        public string MusteriAdres { get; set; }
        public Nullable<int> MusteriHizmetNo { get; set; }
        public string MusteriMail { get; set; }
    
        public virtual Hizmetler Hizmetler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler> Siparislers { get; set; }
    }
}
