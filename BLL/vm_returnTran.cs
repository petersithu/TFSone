//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class vm_returnTran
    {
        public short IssueID { get; set; }
        public short MemberID { get; set; }
        public Nullable<short> StaffID { get; set; }
        public short BookID { get; set; }
        public Nullable<System.DateTime> DateIssue { get; set; }
        public Nullable<System.DateTime> DateDue { get; set; }
        public Nullable<System.DateTime> DateReturn { get; set; }
        public string IssueStatus { get; set; }
        public string Remarks { get; set; }
    }
}
