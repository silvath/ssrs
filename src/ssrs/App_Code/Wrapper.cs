
using Microsoft.Reporting.WebForms;
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

        private IReportServerCredentials GetCredentialViewer()
        {
            string user = ConfigurationManager.AppSettings["User"];
            if (!string.IsNullOrEmpty(user))
            {
                string password = ConfigurationManager.AppSettings["Password"];
                string domain = ConfigurationManager.AppSettings["Domain"];
                return (new CustomReportCredentials(user, password, domain));
            }
            return (null);
        }

        public CatalogItem[] GetItems(string path)
        {
            return(_ssrs.ListChildren(path, false));
        }

        public void ConfigureReport(ReportViewer reportViewer, string path)
        {
            reportViewer.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["ReportingServices"]);
            reportViewer.ServerReport.ReportPath = path;
            IReportServerCredentials credentials = this.GetCredentialViewer();
            if (credentials != null)
                reportViewer.ServerReport.ReportServerCredentials = credentials;
        }
    }
}