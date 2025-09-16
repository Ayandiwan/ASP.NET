    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;


    namespace Async_Pro
    {
        public partial class pra_07 : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                RegisterAsyncTask(new PageAsyncTask(MyAsyncMethod));

            }

            private async Task MyAsyncMethod()
            {
                await Task.Delay(2000); // Simulate 2-second delay
                Label1.Text = "Hello from async method!";
            }
        }
    }
