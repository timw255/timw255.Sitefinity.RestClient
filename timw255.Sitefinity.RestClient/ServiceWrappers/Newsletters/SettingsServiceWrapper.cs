using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Modules.Newsletters.Services.ViewModel;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Newsletters
{
    public class SettingsServiceWrapper : ServiceWrapper
    {
        public SettingsServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Newsletters/Settings.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/pop3test/")]
        public string TestPop3Server(Pop3SettingsViewModel settings)
        {
            var request = new RestRequest(this.ServiceUrl + "/pop3test/", Method.POST);

            request.AddParameter("application/json", SerializeObject(settings), ParameterType.RequestBody);

            return ExecuteRequestFor<string>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/smtptest/")]
        public string TestSmtpServer(SmtpSettingsViewModel settings)
        {
            var request = new RestRequest(this.ServiceUrl + "/smtptest/", Method.POST);

            request.AddParameter("application/json", SerializeObject(settings), ParameterType.RequestBody);

            return ExecuteRequestFor<string>(request);
        }
    }
}
