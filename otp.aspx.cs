using System;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;

namespace Agriculture_Equipment_Store
{
    public partial class otp: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["Email"] == null)
            {
                lblMessage.Text = "⚠️ No registration data found. Please register first.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                btnVerify.Enabled = false;
            }

        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            if (Session["OTP"] != null && txtOTP.Text.Trim() == Session["OTP"].ToString())
            {
                lblMessage.Text = "✅ OTP Verified Successfully!";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                try
                {
                    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);

                    string query = @"INSERT INTO Userlogin
                                        (Name, Email, Password, Role, PhoneNumber, Addrese)
                                         VALUES(@Name, @Email, @Password, @Role, @PhoneNumber, @Addrese)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name", Session["UserName"]);
                    cmd.Parameters.AddWithValue("@Email", Session["Email"]);
                    cmd.Parameters.AddWithValue("@Password", Session["Password"]);
                    cmd.Parameters.AddWithValue("@Role", Session["Role"]);
                    cmd.Parameters.AddWithValue("@PhoneNumber", Session["PhoneNumber"]);
                    cmd.Parameters.AddWithValue("@Addrese", Session["Address"]);

                    con.Open();
                    cmd.ExecuteNonQuery();



                    Session.Clear();
                    Response.Redirect("login.aspx");
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "❌ Database Error: " + ex.Message;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblMessage.Text = "❌ Invalid OTP. Please try again.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Session.Clear();

            string script = @"
        <script>
            alert('❌ You did not enter OTP, registration is cancelled.');
            window.location='login.aspx';
        </script>";

            ClientScript.RegisterStartupScript(this.GetType(), "CancelAlert", script);
        }

    }
}
