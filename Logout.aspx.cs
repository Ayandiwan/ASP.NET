using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ad"] == null)
            {
                Response.Redirect("loginpage.aspx");
            }
            else
            {
                Session.Clear();
                Session.Abandon();
                Response.Redirect("loginpage.aspx");
            }

        }
    }
}