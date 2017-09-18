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
    
    public partial class TransferLog
    {
        public int ID { get; set; }
        public System.DateTime GeneratedDatetime { get; set; }
        public System.DateTime TransferDatetime { get; set; }
        public int BuyerIntegrationTypeID { get; set; }
        public string Description { get; set; }
        public int TransferredTo { get; set; }
        public Nullable<int> ProductSlabId { get; set; }
        public bool IsActualPrice { get; set; }
        public int LeadId { get; set; }
        public string BuyerReturnLeadId { get; set; }
        public int UserId { get; set; }
        public bool Return { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> BuyerProductScheduleId { get; set; }
    
        public virtual BuyerMaster BuyerMaster { get; set; }
        public virtual BuyerProductSchedule BuyerProductSchedule { get; set; }
        public virtual CommonLead CommonLead { get; set; }
        public virtual ProductSlab ProductSlab { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
