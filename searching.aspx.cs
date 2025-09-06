using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Work
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ad"] == null)
            {
                Response.Redirect("loginpage.aspx");
            }

        }

        void srh(string nm="-1")
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            DataSet ds=new DataSet();
            SqlDataAdapter da=new SqlDataAdapter("select * from ad where Name LIKE '%"+nm+"%'",con);

            da.Fill(ds);
            GridView1.DataSource= ds;
            GridView1.DataBind();
           
        }

      
        protected void txtsrh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                srh(txtsrh.Text.Trim());


            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }
        }
    }
}