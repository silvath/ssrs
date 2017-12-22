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
                this.ViewReport(this.Request.QueryString["type"], this.Request.QueryString["Url"]);
            }
        }

        private void ViewReport(string type, string path)
        {
            Wrapper wrapper = new Wrapper();
            this.iFrameReport.Attributes["Src"] = wrapper.CreateReportUri(type ?? "Report", path);
        }
    }
}