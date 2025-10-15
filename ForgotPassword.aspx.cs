using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Agriculture_Equipment_Store
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string username = txtuname.Text.Trim();
            string curpas = txtcurpas.Text.Trim();
            string newpas = txtnewpass.Text.Trim();
            string reppas = txtreppas.Text.Trim();

            if (newpas != reppas)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('New Password and Repeat Password do not match!');", true);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);
                con.Open();

                // ✅ Check current password first

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Userlogin] WHERE Name=@Name AND Password=@Password", con);
                cmd.Parameters.AddWithValue("@Name", username);
                cmd.Parameters.AddWithValue("@Password", curpas);

                int cou = (int)cmd.ExecuteScalar();

                if (cou > 0)
                {
                    // ✅ Update password
                    SqlCommand updateCmd = new SqlCommand("UPDATE [Userlogin] SET Password=@NewPassword WHERE Name=@Name", con);
                    updateCmd.Parameters.AddWithValue("@NewPassword", newpas);
                    updateCmd.Parameters.AddWithValue("@Name", username);

                    int rows = updateCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Password updated successfully!');", true);
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Something went wrong while updating!');", true);
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Invalid Username or Current Password!');", true);
                }
            }

            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            txtuname.Text = "";
        }
    }
}
