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
    
    public partial class Personel
    {
        public int PersonelID { get; set; }
        public string PersonelAdSoyad { get; set; }
        public string PersonelTcNo { get; set; }
        public int PersonelYas { get; set; }
        public string PersonelMail { get; set; }
        public string PersonelTelefon { get; set; }
        public string PersonelAdres { get; set; }
        public int SubeSubeID { get; set; }
    
        public virtual Sube Sube { get; set; }
    }
}
