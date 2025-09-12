using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Globalization
{
    public partial class Lanng : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {
            // Get selected language from session or default to English
            string selectedLanguage = Session["SelectedLanguage"] as string ?? "en";

            // Set culture
            Thread.CurrentThread.CurrentCulture = new CultureInfo(selectedLanguage);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedLanguage);

            base.InitializeCulture();
        }




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblWelcome.Text = Resources.Resource1.Welcome;

                // Set dropdown to selected language
                ddlLanguage.SelectedValue = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            }

        }

        protected void ddlLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLang = ddlLanguage.SelectedValue;
            Session["SelectedLanguage"] = selectedLang;

            // Reload page to apply culture
            Response.Redirect(Request.Url.ToString());

        }
    }
}