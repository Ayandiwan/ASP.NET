using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Work
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (Session["ad"] == null)
            {
                Response.Redirect("loginpage.aspx");
            }



            if (!IsPostBack)
            {
                collage.Items.Clear();
                collage.Items.Add(new ListItem("select", "0"));
                collage.Items.Add(new ListItem("AIT", "1"));
                collage.Items.Add(new ListItem("FPT", "2"));
                collage.Items.Add(new ListItem("BACA", "3"));
                collage.Items.Add(new ListItem("HOTI", "4"));


            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (collage.SelectedItem.Value)
            {
                case "1":
                    pro.Items.Clear();
                    pro.Items.Add(new ListItem("Select"));
                    pro.Items.Add(new ListItem("YRG"));
                    pro.Items.Add(new ListItem("MPR"));
                    pro.Items.Add(new ListItem("KUC"));



                    break;

                case "2":
                    pro.Items.Clear();
                    pro.Items.Add(new ListItem("Select"));
                    pro.Items.Add(new ListItem("F1"));
                    pro.Items.Add(new ListItem("F2"));
                    pro.Items.Add(new ListItem("F3"));



                    break;

                case "3":
                    pro.Items.Clear();
                    pro.Items.Add(new ListItem("Select"));
                    pro.Items.Add(new ListItem("B1"));
                    pro.Items.Add(new ListItem("B2"));
                    pro.Items.Add(new ListItem("B3"));

                    break;

                case "4":
                    pro.Items.Clear();
                    pro.Items.Add(new ListItem("Select"));
                    pro.Items.Add(new ListItem("H1"));
                    pro.Items.Add(new ListItem("H2"));
                    pro.Items.Add(new ListItem("H3"));



                    break;


                   
            }



        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Response.Write("Submit Done");

        }

       
    }
}