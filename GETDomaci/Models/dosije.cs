//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GETDomaci.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dosije
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dosije()
        {
            this.ispits = new HashSet<ispit>();
        }
    
        public int indeks { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public Nullable<System.DateTime> datum_upisa { get; set; }
        public Nullable<System.DateTime> datum_rodjenja { get; set; }
        public string mesto_rodjenja { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ispit> ispits { get; set; }
    }
}
