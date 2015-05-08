using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Newsletters
{
    public class MailingListServiceWrapper : ServiceWrapper
    {
        public MailingListServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Newsletters/MailingList.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batchdelete/?provider={provider}")]
        public bool BatchDeleteMailingLists(Guid[] mailingListIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batchdelete/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(mailingListIds), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{mailingListId}/?provider={provider}")]
        public bool DeleteMailingList(Guid mailingListId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{mailingListId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("mailingListId", mailingListId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/{mailingListId}/?provider={provider}")]
        public MailingListViewModel GetMailingList(Guid mailingListId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{mailingListId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("mailingListId", mailingListId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<MailingListViewModel>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<MailingListViewModel> GetMailingLists(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<MailingListViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{mailingListId}/?provider={provider}")]
        public MailingListViewModel SaveMailingList(Guid mailingListId, MailingListViewModel mailingList, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{mailingListId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("mailingListId", mailingListId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(mailingList), ParameterType.RequestBody);

            return ExecuteRequest<MailingListViewModel>(request);
        }
    }
}
