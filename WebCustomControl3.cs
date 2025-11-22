using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p1
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:WebCustomControl3 runat=server></{0}:WebCustomControl3>")]
    public class WebCustomControl3 : WebControl,INamingContainer
    {

        private TextBox t1;
        private TextBox t2;
        private Button btn1;
        private Label lbl1;


        protected override void CreateChildControls()
        {
            
            t1 = new TextBox();
            t1.ID = "txtnum1";
            
            this.Controls.Add(t1);

            t2 = new TextBox();
            t2.ID = "txtnum2";

            this.Controls.Add(t2);


            btn1 = new Button();
            btn1.Text = "Click";
            btn1.ID = "Ans";
            btn1.Click += ad;
            this.Controls.Add(btn1);    



            lbl1 = new Label();
            lbl1.ID = "ans2";

            this.Controls.Add (lbl1);


        }


        private void ad(object sender,EventArgs e)
        {

            EnsureChildControls();

            int a = Convert.ToInt32(t1.Text);
            int b = Convert.ToInt32(t2.Text);

            lbl1.Text = "Anser:"+(a+b);



        }
        protected override void Render(HtmlTextWriter writer)
        {

            EnsureChildControls ();
            base.Render(writer);

        }

        
    }
}
