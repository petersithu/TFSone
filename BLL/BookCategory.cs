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
    
    public partial class BookCategory
    {
        public BookCategory()
        {
            this.Books = new HashSet<Book>();
        }
    
        public short BookCategoryID { get; set; }
        public string BookCatetgoryName { get; set; }
        public string ShelfNo { get; set; }
    
        public virtual ICollection<Book> Books { get; set; }
    }
}
