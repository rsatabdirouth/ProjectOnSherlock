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
    
    public partial class UserApplicationAccess
    {
        public int ID { get; set; }
        public int ApplicationRouteID { get; set; }
        public int RoleID { get; set; }
    
        public virtual ApplicationRouteMaster ApplicationRouteMaster { get; set; }
        public virtual RoleMaster RoleMaster { get; set; }
    }
}