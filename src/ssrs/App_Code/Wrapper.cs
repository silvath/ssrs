
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using ReportingService = ssrs.App_Code.ReportingService2010;

namespace ssrs.App_Code
{
    public class Wrapper
    {
        private ReportingService _ssrs;

        public Wrapper()
        {
            _ssrs = new ReportingService();
            _ssrs.Url = string.Format("{0}{1}",ConfigurationManager.AppSettings["ReportingServices"], _ssrs.GetWSDL());
            _ssrs.Credentials = this.GetCredential();
        }

        private ICredentials GetCredential()
        {
            string user = ConfigurationManager.AppSettings["User"];
            if (!string.IsNullOrEmpty(user))
            {
                string password = ConfigurationManager.AppSettings["Password"];
                string domain = ConfigurationManager.AppSettings["Domain"];
                if (string.IsNullOrEmpty(domain))
                    return (new NetworkCredential(user, password));
                return (new NetworkCredential(user, password, domain));
            }
            return (CredentialCache.DefaultCredentials);
        }

        public CatalogItem[] GetItems(string path)
        {
            return(_ssrs.ListChildren(path, false));
        }

        public string CreateReportUri(string type, string path)
        {
            bool showParameters = true;
            bool showReportToolbar = true;
            //Here we can heve MobileReport (DataZen) and PowerBIReport (PowerBI)
            if (type == "Report")
            {
                return(string.Format("{0}?{1}&rs:Command=Render{2}{3}&rc:ShowBackButton=true", ConfigurationManager.AppSettings["ReportingServices"], path, !showParameters ? "&rc:Parameters=Collapsed" : "", showReportToolbar ? "" : "&rc:Toolbar=false"));
            }
            return (string.Empty);
        }
    }
}