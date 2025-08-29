using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Agriculture_Equipment_Store
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           




        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {



            try
            {

                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select count(*)  from [Userlogin] where Name=@Name and Password=@Password";
                cmd.Parameters.AddWithValue("@Name", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    Session["user"] = txtUsername.Text.Trim();
                    Response.Write("Login done");

                }
                else
                {
                    Response.Write("invalalid user");

                }



            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }



        }
    }
}