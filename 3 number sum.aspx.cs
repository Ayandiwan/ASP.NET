using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdRevision
{
    public partial class _3_number_sum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            int ans = 0;
            int n1=Convert.ToInt32(txtnum1.Text.Trim());
            int n2 = Convert.ToInt32(txtnum2.Text.Trim());
            int n3 = Convert.ToInt32(txtnum3.Text.Trim());

            ans=n1 + n2 + n3;
            Response.Write(ans);

        }
    }
}