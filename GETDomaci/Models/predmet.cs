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
    
    public partial class predmet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public predmet()
        {
            this.ispits = new HashSet<ispit>();
        }
    
        public int id_predmeta { get; set; }
        public string sifra { get; set; }
        public string naziv { get; set; }
        public short bodovi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ispit> ispits { get; set; }
    }
}
