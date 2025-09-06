using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internal
{
    public partial class ConferenceRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (fuProof.HasFile)
            {
                string filePath = "~/Uploads/" + fuProof.FileName;
                fuProof.SaveAs(Server.MapPath(filePath));

                DataTable dt = new DataTable();
                dt.Columns.Add("PaperTitle");
                dt.Columns.Add("Name");
                dt.Columns.Add("Email");

                dt.Rows.Add(txtPaperTitle.Text, txtName.Text, txtEmail.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}