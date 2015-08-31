using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class TestGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SA40Team07bEntities ctx = new SA40Team07bEntities();
            //List<Author> tl = ctx.Authors.ToList();
            //if(tl != null)
            //{
            //    GridView1.DataSource = tl;
            //    GridView1.DataBind();
            //}
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
        }
    }
}