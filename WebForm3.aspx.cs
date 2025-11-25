using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {
            string lang = "en";

            if (Session["lang"] != null)
            {
                if (Session["lang"] != null)
                

                    lang= Session["lang"].ToString();
                
                UICulture=lang;
                Culture = lang;

                Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);


            }



            base.InitializeCulture();

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                if (Session["lang"] != null)
                {
                    DropDownList1.SelectedValue= Session["lang"].ToString();

                }


            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["lang"]=DropDownList1.SelectedValue.ToString();

            Response.Redirect(Request.Url.AbsolutePath);
        }
    }
}