using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Modules.Newsletters.Services.ViewModel;
using Telerik.Sitefinity.Web.Services;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Newsletters
{
    public class MessageTemplateServiceWrapper : ServiceWrapper
    {
        public MessageTemplateServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Newsletters/MessageTemplate.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batchdelete/?provider={provider}")]
        public bool BatchDeleteTemplates(Guid[] templateIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batchdelete/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(templateIds), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{templateId}/?provider={provider}")]
        public bool DeleteTemplate(Guid templateId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{templateId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("templateId", templateId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebGet(UriTemplate = "/{templateId}/?provider={provider}")]
        public MessageBodyViewModel GetTemplate(Guid templateId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{templateId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("templateId", templateId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<MessageBodyViewModel>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<MessageBodyViewModel> GetTemplates(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<MessageBodyViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{templateId}/?provider={provider}&isPageBased={isPageBased}")]
        public MessageBodyViewModel SaveTemplate(Guid templateId, MessageBodyViewModel template, string provider, bool isPageBased)
        {
            var request = new RestRequest(this.ServiceUrl + "/{templateId}/?provider={provider}&isPageBased={isPageBased}", Method.PUT);

            request.AddUrlSegment("templateId", templateId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("isPageBased", isPageBased.ToString());

            request.AddParameter("application/json", SerializeObject(template), ParameterType.RequestBody);

            return ExecuteRequestFor<MessageBodyViewModel>(request);
        }
    }
}
