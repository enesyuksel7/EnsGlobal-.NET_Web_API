//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnsGlobal.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Satislar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Satislar()
        {
            this.Sigortalar = new HashSet<Sigortalar>();
        }
    
        public int SatisID { get; set; }
        public int ArabaID { get; set; }
        public int SubeID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string AdSoyad { get; set; }
        public Nullable<int> Ucret { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> TelNo { get; set; }
    
        public virtual Arabalar Arabalar { get; set; }
        public virtual SubeAbonelik SubeAbonelik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sigortalar> Sigortalar { get; set; }
    }
}
