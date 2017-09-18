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
    
    public partial class DebtLeadLog
    {
        public int ID { get; set; }
        public int DebtLeadId { get; set; }
        public int Stage { get; set; }
        public int DebtEmploymentStatus { get; set; }
        public int ResidentialStatus { get; set; }
        public int ResidentialLocation { get; set; }
        public bool HadCcj { get; set; }
        public int DebtType { get; set; }
        public int TotalUnsecuredDebt { get; set; }
        public int TotalCreditors { get; set; }
        public int MonthlyRepayments { get; set; }
        public int MonthlyDisposable { get; set; }
        public int MonthlyIncome { get; set; }
        public int CommonLeadId { get; set; }
        public System.DateTime Dob { get; set; }
        public int Age { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
        public Nullable<int> DebtCategory { get; set; }
        public string DebtTypes { get; set; }
    
        public virtual CommonLead CommonLead { get; set; }
        public virtual DebtLead DebtLead { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
