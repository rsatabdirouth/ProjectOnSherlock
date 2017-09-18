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
    
    public partial class LeadEmailRequest
    {
        public int ID { get; set; }
        public int CommonLeadId { get; set; }
        public int EmailRequestId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual CommonLead CommonLead { get; set; }
        public virtual EmailRequest EmailRequest { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
