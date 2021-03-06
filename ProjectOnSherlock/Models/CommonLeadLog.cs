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
    
    public partial class CommonLeadLog
    {
        public int ID { get; set; }
        public int CommonLeadId { get; set; }
        public int Stage { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string Address1 { get; set; }
        public string Email { get; set; }
        public int ProductMasterId { get; set; }
        public string IpAddress { get; set; }
        public string Source { get; set; }
        public string MatchType { get; set; }
        public string Keyword { get; set; }
        public Nullable<int> LeadStatus { get; set; }
        public int WebsiteMasterId { get; set; }
        public string ProductName { get; set; }
        public string SourceUid { get; set; }
        public int LeadCategory { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
        public bool Opt { get; set; }
        public string UserAgent { get; set; }
        public string Query { get; set; }
        public string Description { get; set; }
    
        public virtual CommonLead CommonLead { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
        public virtual WebsiteMaster WebsiteMaster { get; set; }
    }
}
