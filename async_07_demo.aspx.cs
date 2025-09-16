using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Async_Pro
{
    public partial class async_07_demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AddOnPreRenderCompleteAsync(new BeginEventHandler(BeginAsyncOperation),
                                       new EndEventHandler(EndAsyncOperation));
        }

        IAsyncResult BeginAsyncOperation(object sender, EventArgs e, AsyncCallback cb, object extraData)
        {
            Func<string> asyncWork = () =>
            {
                // Simulate a long-running task (e.g., API call or DB query)
                Thread.Sleep(2000); // 2 seconds delay
                return "Async operation completed at " + DateTime.Now.ToLongTimeString();
            };

            return asyncWork.BeginInvoke(cb, asyncWork);
        }

        void EndAsyncOperation(IAsyncResult ar)
        {
            Func<string> asyncWork = (Func<string>)ar.AsyncState;
            string result = asyncWork.EndInvoke(ar);

            lblResult.Text = result;
        }



    }
}