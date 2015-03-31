using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Web.Services;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.DynamicModules
{
    public class BackendGridStructureServiceWrapper : ServiceWrapper
    {
        public BackendGridStructureServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/DynamicModules/BackendGridStructureService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/?parentTypeId={parentTypeId}")]
        public CollectionContext<GridColumnWrapper> GetBackendGrid(Guid parentTypeId)
        {
            var request = new RestRequest(this.ServiceUrl + "/?parentTypeId={parentTypeId}", Method.GET);

            request.AddUrlSegment("parentTypeId", parentTypeId.ToString());

            return ExecuteRequestFor<CollectionContext<GridColumnWrapper>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/?parentTypeId={parentTypeId}")]
        public void ModifyBackendGrid(GridColumnWrapper[] gridColumns, Guid parentTypeId)
        {
            var request = new RestRequest(this.ServiceUrl + "/?parentTypeId={parentTypeId}", Method.PUT);

            request.AddUrlSegment("parentTypeId", parentTypeId.ToString());

            request.AddParameter("application/json", SerializeObject(gridColumns), ParameterType.RequestBody);

            ExecuteRequest(request);
        }
    }
}
