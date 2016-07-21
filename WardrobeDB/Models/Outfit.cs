//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WardrobeDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Outfit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Outfit()
        {
            this.Accessories = new HashSet<WardrobeItem>();
        }
    
        public int OutfitID { get; set; }
        public int TopID { get; set; }
        public int BottomID { get; set; }
        public int ShoeID { get; set; }
    
        public virtual WardrobeItem Top { get; set; }
        public virtual WardrobeItem Bottom { get; set; }
        public virtual WardrobeItem Shoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WardrobeItem> Accessories { get; set; }
    }
}
