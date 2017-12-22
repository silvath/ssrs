using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ssrs.App_Code
{
    [Serializable]
    public class CustomReportCredentials : IReportServerCredentials
    {
        private string _user;
        private string _password;
        private string _domain;

        public CustomReportCredentials(string user, string password, string domain)
        {
            _user = user;
            _password = password;
            _domain = domain;
        }

        public System.Security.Principal.WindowsIdentity ImpersonationUser
        {
            get { return (null); }
        }

        public System.Net.ICredentials NetworkCredentials
        {
            get { return (new System.Net.NetworkCredential(_user, _password, _domain)); }
        }

        public bool GetFormsCredentials(out System.Net.Cookie authCookie, out string user, out string password, out string authority)
        {
            authCookie = null;
            user = password = authority = null;
            return false;
        }
    }
}