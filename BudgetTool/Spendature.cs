//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetTool
{
    using System;
    using System.Collections.Generic;
    
    public partial class Spendature
    {
        public int SpendatureId { get; set; }
        public int StoreId { get; set; }
        public int StoreTypeId { get; set; }
        public decimal AmountSpent { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<int> SpendatureTypeId { get; set; }
    
        public virtual SpendatureType SpendatureType { get; set; }
        public virtual Store Store { get; set; }
        public virtual StoreType StoreType { get; set; }
    }
}
