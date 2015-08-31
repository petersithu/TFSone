using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApplication1
{
    public partial class TestBLLgridview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BookController bookcontroller = new BookController();
            List<string> bl = bookcontroller.getBookTitleA();
            GridView1.DataSource = bl;
            GridView1.DataBind();
            
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Title";
            }
        }
    }
}