using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers
{
    public class SitefinityProjectServiceWrapper : ServiceWrapper
    {
        public SitefinityProjectServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/SitefinityProject.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate = "/All")]
        public ProjectInfo GetAll()
        {
            var request = new RestRequest(this.ServiceUrl + "/All", Method.GET);

            return ExecuteRequestFor<ProjectInfo>(request);
        }

        //[WebGet(UriTemplate = "/Name")]
        public string GetName()
        {
            var request = new RestRequest(this.ServiceUrl + "/Name", Method.GET);

            return ExecuteRequestFor<string>(request);
        }

        //[WebGet(UriTemplate = "/SfVersion")]
        public string GetSfVersion()
        {
            var request = new RestRequest(this.ServiceUrl + "/SfVersion", Method.GET);

            return ExecuteRequestFor<string>(request);
        }

        //[WebGet(UriTemplate = "/Version")]
        public string GetVersion()
        {
            var request = new RestRequest(this.ServiceUrl + "/Version", Method.GET);

            return ExecuteRequestFor<string>(request);
        }
    }
}
