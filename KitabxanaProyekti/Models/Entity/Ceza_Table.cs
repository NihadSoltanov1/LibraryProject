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
    
    public partial class Ceza_Table
    {
        public int ID { get; set; }
        public Nullable<int> Istifadeci { get; set; }
        public Nullable<int> Emeliyyat { get; set; }
        public Nullable<decimal> Cerime { get; set; }
        public Nullable<System.DateTime> BaslangicTarixi { get; set; }
        public Nullable<System.DateTime> BitisTarixi { get; set; }
    
        public virtual Emeliyyat_Table Emeliyyat_Table { get; set; }
        public virtual Istifadeci_Table Istifadeci_Table { get; set; }
    }
}
