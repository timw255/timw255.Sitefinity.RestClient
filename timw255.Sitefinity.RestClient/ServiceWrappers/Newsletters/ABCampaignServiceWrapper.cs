using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Newsletters
{
    public class ABCampaignServiceWrapper : ServiceWrapper
    {
        public ABCampaignServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Newsletters/ABCampaign.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batchdelete/?provider={provider}")]
        public bool BatchDeleteCampaigns(Guid[] campaignIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batchdelete/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(campaignIds), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/abtests/{issueAId}/?provider={provider}&isFromScratch={isFromScratch}")]
        public ABCampaignViewModel CreateAbTest(Guid issueAId, bool isFromScratch, IssueViewModel issueB, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/abtests/{issueAId}/?provider={provider}&isFromScratch={isFromScratch}", Method.PUT);

            request.AddUrlSegment("issueAId", issueAId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("isFromScratch", isFromScratch.ToString());

            request.AddParameter("application/json", SerializeObject(issueB), ParameterType.RequestBody);

            return ExecuteRequestFor<ABCampaignViewModel>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/decidewinner/{abCampaignId}/{winningCampaignId}/?provider={provider}")]
        public bool DecideWinner(Guid abCampaignId, Guid winningCampaignId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/decidewinner/{abCampaignId}/{winningCampaignId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("abCampaignId", abCampaignId.ToString());
            request.AddUrlSegment("winningCampaignId", winningCampaignId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{campaignId}/?provider={provider}")]
        public bool DeleteCampaign(Guid campaignId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{campaignId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("campaignId", campaignId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/endtesting/{abCampaignId}/?provider={provider}")]
        public string EndTesting(Guid abCampaignId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/endtesting/{abCampaignId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("abCampaignId", abCampaignId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<string>(request);
        }

        //[WebGet(UriTemplate = "/abtests/{rootCampaignId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ABCampaignGridViewModel> GetABTestsPerCampaign(string provider, Guid rootCampaignId, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/abtests/{rootCampaignId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("rootCampaignId", rootCampaignId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<ABCampaignGridViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/{campaignId}/?provider={provider}")]
        public ABCampaignViewModel GetCampaign(Guid campaignId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{campaignId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("campaignId", campaignId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<ABCampaignViewModel>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ABCampaignViewModel> GetCampaigns(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<ABCampaignViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{campaignId}/?provider={provider}")]
        public ABCampaignViewModel SaveCampaign(Guid campaignId, ABCampaignViewModel campaign, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{campaignId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("campaignId", campaignId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(campaign), ParameterType.RequestBody);

            return ExecuteRequestFor<ABCampaignViewModel>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/setconclusion/{abTestId}/?provider={provider}")]
        public bool SetConclusion(Guid abTestId, string value, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/setconclusion/{abTestId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("abTestId", abTestId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(value), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/settestingnote/{abTestId}/?provider={provider}")]
        public bool SetTestingNote(Guid abTestId, string value, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/settestingnote/{abTestId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("abTestId", abTestId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(value), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/starttesting/{abCampaignId}/?provider={provider}")]
        public bool StartTesting(Guid abCampaignId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/starttesting/{abCampaignId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("abCampaignId", abCampaignId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<bool>(request);
        }
    }
}
