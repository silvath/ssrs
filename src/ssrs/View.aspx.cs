using ssrs.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ssrs
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string path = this.Request.QueryString["Url"];
                this.ViewReport(path);
            }
        }

        private void ViewReport(string path)
        {
            Wrapper wrapper = new Wrapper();
            wrapper.ConfigureReport(this.ReportViewer, path);
        }
    }
}