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
    
    public partial class PPILead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PPILead()
        {
            this.PPILeadLogs = new HashSet<PPILeadLog>();
        }
    
        public int ID { get; set; }
        public int LeadId { get; set; }
        public System.DateTime Dob { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public int LoanStatus { get; set; }
        public int PPIEmploymentStatus { get; set; }
        public int Period { get; set; }
        public string AdditionalInformation { get; set; }
        public int MonthlyRepayments { get; set; }
        public int Amount { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual CommonLead CommonLead { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PPILeadLog> PPILeadLogs { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
