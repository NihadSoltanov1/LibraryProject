//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KitabxanaProyekti.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Isci_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Isci_Table()
        {
            this.Emeliyyat_Table = new HashSet<Emeliyyat_Table>();
        }
    
        public byte ID { get; set; }
        public string Isci { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emeliyyat_Table> Emeliyyat_Table { get; set; }
    }
}