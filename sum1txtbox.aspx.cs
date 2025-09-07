using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdRevision
{
    public partial class sum1txtbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void txtnum1_TextChanged(object sender, EventArgs e)
        {

            if (ViewState["ad"]==null)
            {
                ViewState["ad"] = txtnum1.Text.Trim();
                Response.Write("Addition:" + ViewState["ad"]);

            }
            else
            {
                int n1 = Convert.ToInt32(ViewState["ad"].ToString());
                int n2 = Convert.ToInt32(txtnum1.Text.Trim());

                ViewState["ad"] = n1 + n2;
                Response.Write("Addition:"+ ViewState["ad"].ToString());

            }


        }

        protected void txtnum2_TextChanged(object sender, EventArgs e)
        {

            if (ViewState["ad"] == null)
            {
                ViewState["ad"] = txtnum2.Text.Trim();
                Response.Write("Addition:" + ViewState["ad"]);

            }
            else
            {
                int n1 = Convert.ToInt32(ViewState["ad"].ToString());
                int n2 = Convert.ToInt32(txtnum2.Text.Trim());

                ViewState["ad"] = n1 + n2;
                Response.Write("Addition:" + ViewState["ad"].ToString());

            }
        }
    }
}