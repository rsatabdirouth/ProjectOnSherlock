//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectOnSherlock.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyerProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BuyerProduct()
        {
            this.BuyerProductLeadCategories = new HashSet<BuyerProductLeadCategory>();
            this.BuyerProductLeadTypes = new HashSet<BuyerProductLeadType>();
        }
    
        public int ID { get; set; }
        public int BuyerMasterId { get; set; }
        public int ProductMasterId { get; set; }
        public int IntegrationType { get; set; }
        public int State { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string WSDL { get; set; }
        public string AffiliateId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
        public Nullable<int> BuyerFaceForProduct_ID { get; set; }
        public int Weightage { get; set; }
        public Nullable<bool> IsSendNotifyMail { get; set; }
        public Nullable<bool> IsTransferDelay { get; set; }
    
        public virtual BuyerFaceForProduct BuyerFaceForProduct { get; set; }
        public virtual BuyerMaster BuyerMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerProductLeadCategory> BuyerProductLeadCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerProductLeadType> BuyerProductLeadTypes { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}