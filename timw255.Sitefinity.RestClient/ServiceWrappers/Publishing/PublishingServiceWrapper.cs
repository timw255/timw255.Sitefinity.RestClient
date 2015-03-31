using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Publishing.Web.Services.Data;
using Telerik.Sitefinity.Web.Services;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Publishing
{
    public class PublishingServiceWrapper : ServiceWrapper
    {
        public PublishingServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Publishing/PublishingService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "batch/?providerName={providerName}")]
        public bool BatchDeletePoints(string providerName, Guid[] Ids)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/?providerName={providerName}", Method.POST);

            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", SerializeObject(Ids), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/batch/setactive/?providerName={providerName}&setActive={setActive}")]
        public bool BatchSetActive(string providerName, Guid[] ids, bool setActive)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/setactive/?providerName={providerName}&setActive={setActive}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("setActive", setActive.ToString());

            request.AddParameter("application/json", SerializeObject(ids), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{pointId}/?providerName={providerName}&createNew={createNew}&itemTemplate={itemTemplate}")]
        public bool DeletePublishingPoint(string providerName, Guid pointId, bool createNew, string itemTemplate)
        {
            var request = new RestRequest(this.ServiceUrl + "/{pointId}/?providerName={providerName}&createNew={createNew}&itemTemplate={itemTemplate}", Method.DELETE);

            request.AddUrlSegment("pointId", pointId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("createNew", createNew.ToString());
            request.AddUrlSegment("itemTemplate", itemTemplate);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/indboundpipes/?providerName={providerName}&pipeTypeName={pipeTypeName}&sort={sort}&filter={filter}&skip={skip}&take={take}")]
        public CollectionContext<PublishingPipeViewModel> GetInboundPublishingPipes(string providerName, string pipeTypeName, string sort, string filter, int skip, int take)
        {
            var request = new RestRequest(this.ServiceUrl + "/indboundpipes/?providerName={providerName}&pipeTypeName={pipeTypeName}&sort={sort}&filter={filter}&skip={skip}&take={take}", Method.GET);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("pipeTypeName", pipeTypeName);
            request.AddUrlSegment("sort", sort);
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());

            return ExecuteRequestFor<CollectionContext<PublishingPipeViewModel>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/pipes/?providerName={providerName}&pipeTypeName={pipeTypeName}&sort={sort}&filter={filter}&skip={skip}&take={take}")]
        public CollectionContext<PublishingPipeViewModel> GetOutgoingPublishingPipes(string providerName, string pipeTypeName, string sort, string filter, int skip, int take)
        {
            var request = new RestRequest(this.ServiceUrl + "/pipes/?providerName={providerName}&pipeTypeName={pipeTypeName}&sort={sort}&filter={filter}&skip={skip}&take={take}", Method.GET);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("pipeTypeName", pipeTypeName);
            request.AddUrlSegment("sort", sort);
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());

            return ExecuteRequestFor<CollectionContext<PublishingPipeViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/{pointId}/?providerName={providerName}&createNew={createNew}&itemTemplate={itemTemplate}")]
        public DataItemContext<PublishingPointDetailViewModel> GetPublishingPoint(string providerName, Guid pointId, bool createNew, string itemTemplate)
        {
            var request = new RestRequest(this.ServiceUrl + "/{pointId}/?providerName={providerName}&createNew={createNew}&itemTemplate={itemTemplate}", Method.GET);

            request.AddUrlSegment("pointId", pointId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("createNew", createNew.ToString());
            request.AddUrlSegment("itemTemplate", itemTemplate);
            
            return ExecuteRequestFor<DataItemContext<PublishingPointDetailViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/?providerName={providerName}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<PublishingPointViewModel> GetPublishingPoints(string providerName, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?providerName={providerName}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<PublishingPointViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/reindex/{pointId}/?providerName={providerName}")]
        public bool ReindexSearchContent(string providerName, Guid pointId)
        {
            var request = new RestRequest(this.ServiceUrl + "/reindex/{pointId}/?providerName={providerName}", Method.PUT);

            request.AddUrlSegment("pointId", pointId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/runpipes/{pointId}/?providerName={providerName}")]
        public bool RunPipes(string providerName, Guid pointId)
        {
            var request = new RestRequest(this.ServiceUrl + "/runpipes/{pointId}/?providerName={providerName}", Method.PUT);

            request.AddUrlSegment("pointId", pointId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{pointId}/?providerName={providerName}&createNew={createNew}&itemTemplate={itemTemplate}")]
        public DataItemContext<PublishingPointDetailViewModel> SavePublishingPoint(DataItemContext<PublishingPointDetailViewModel> point, string providerName, Guid pointId, bool createNew, string itemTemplate)
        {
            var request = new RestRequest(this.ServiceUrl + "/{pointId}/?providerName={providerName}&createNew={createNew}&itemTemplate={itemTemplate}", Method.PUT);

            request.AddUrlSegment("pointId", pointId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("createNew", createNew.ToString());
            request.AddUrlSegment("itemTemplate", itemTemplate);

            request.AddParameter("application/json", SerializeObject(point), ParameterType.RequestBody);

            return ExecuteRequestFor<DataItemContext<PublishingPointDetailViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/setactive/{pointId}/?providerName={providerName}&setActive={setActive}")]
        public bool SetActive(string providerName, Guid pointId, bool setActive)
        {
            var request = new RestRequest(this.ServiceUrl + "/setactive/{pointId}/?providerName={providerName}&setActive={setActive}", Method.PUT);

            request.AddUrlSegment("pointId", pointId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("setActive", setActive.ToString());

            return ExecuteRequestFor<bool>(request);
        }
    }
}
