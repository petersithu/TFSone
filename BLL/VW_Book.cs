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
    
    public partial class VW_Book
    {
        public short BookID { get; set; }
        public string ISBN { get; set; }
        public string BookTitle { get; set; }
        public string BookCatetgoryName { get; set; }
        public string Edition { get; set; }
        public short TotalStock { get; set; }
        public Nullable<short> Available_Stock { get; set; }
    }
}