//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBuyListDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class SavedList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SavedList()
        {
            this.SavedListDetails = new HashSet<SavedListDetail>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
        public Nullable<bool> SHOPPING_LIST { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SavedListDetail> SavedListDetails { get; set; }
    }
}
