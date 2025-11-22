using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace p1
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:WebCustomControl2 runat=server></{0}:WebCustomControl2>")]
    public class WebCustomControl2 : WebControl, INamingContainer
    {

        TextBox t1;
        TextBox t2;
        Button btn;
        Label result;

        protected override void CreateChildControls()
        {
            // TextBox 1
            t1 = new TextBox();
            t1.ID = "txt1";
            this.Controls.Add(t1);

            // Line break
            this.Controls.Add(new LiteralControl("<br/>"));

            // TextBox 2
            t2 = new TextBox();
            t2.ID = "txt2";
            this.Controls.Add(t2);

            // Line break
            this.Controls.Add(new LiteralControl("<br/>"));

            // Button
            btn = new Button();
            btn.ID = "btnAdd";
            btn.Text = "Add";
            btn.Click += Btn_Click;
            this.Controls.Add(btn);

            // Line break
            this.Controls.Add(new LiteralControl("<br/>"));

            // Result label
            result = new Label();
            result.ID = "lblResult";
            this.Controls.Add(result);
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            
            EnsureChildControls();

            int a = Convert.ToInt32(t1.Text);
            int b = Convert.ToInt32(t2.Text);
            result.Text = "sum: " + (a + b);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            EnsureChildControls();
            base.Render(writer);
        }
    }
}
