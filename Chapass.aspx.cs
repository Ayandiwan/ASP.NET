using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Work
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (txtcurpass.Text == Session["pass"].ToString())
            {
                if (txtnewpass.Text.Trim() == txtcurpass.Text.Trim())
                {
                    Response.Write("New password must be different from current password.");
                }
                else
                {
                    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "update [user] set Password=@Password where UserName=@UserName";

                    cmd.Parameters.AddWithValue("@Password", txtnewpass.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserName", Session["ad"].ToString());

                    con.Open();
                    int cou = cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("Password Changed");
                }
            }
            else
            {
                Response.Write("Invalid User");
            }
        }
    }
}
