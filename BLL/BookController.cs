using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookController
    {

        public List<Book> getBookTitle()
        {
           SA40Team07bEntities ctx = new SA40Team07bEntities();
           List<Book> b = new List<Book>();
            b = (from x in ctx.Books
                 select x).ToList();
            return b;
        }

        public List<string> getBookTitleA()
        {
            SA40Team07bEntities ctx = new SA40Team07bEntities();
            List<string> b = new List<string>();
            b = (from x in ctx.Books
                 select x.BookTitle).ToList();
            return b;
        }
    }
}
