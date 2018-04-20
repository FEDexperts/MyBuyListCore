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
    
    public partial class FoodCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoodCategory()
        {
            this.Foods = new HashSet<Food>();
            this.FoodCategories1 = new HashSet<FoodCategory>();
        }
    
        public int FoodCategoryId { get; set; }
        public string FoodCategoryName { get; set; }
        public Nullable<int> ParentCategoryId { get; set; }
        public int ShopDepartmentId { get; set; }
        public int SortOrder { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Food> Foods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodCategory> FoodCategories1 { get; set; }
        public virtual FoodCategory FoodCategory1 { get; set; }
        public virtual ShopDepartment ShopDepartment { get; set; }
    }
}
