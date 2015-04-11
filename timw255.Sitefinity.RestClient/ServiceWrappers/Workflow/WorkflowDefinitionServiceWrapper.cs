using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Workflow
{
    public class WorkflowDefinitionServiceWrapper : ServiceWrapper
    {
        public WorkflowDefinitionServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Workflow/WorkflowDefinitionService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}")]
        public void DeleteWorkflowDefinitions(Guid[] workflowDefinitionIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(workflowDefinitionIds), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&workflowFilter={workflowFilter}")]
        public CollectionContext<WorkflowDefinitionViewModel> GetWorkflowDefinitions(string provider, string sortExpression, int skip, int take, string filter, string workflowFilter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&workflowFilter={workflowFilter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("workflowFilter", workflowFilter);

            return ExecuteRequestFor<CollectionContext<WorkflowDefinitionViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{workflowDefinitionId}/?provider={provider}")]
        public WorkflowDefinitionViewModel SaveWorkflowDefinition(WorkflowDefinitionViewModel workflowDefinitionViewModel, Guid workflowDefinitionId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{workflowDefinitionId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("workflowDefinitionId", workflowDefinitionId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(workflowDefinitionViewModel), ParameterType.RequestBody);

            return ExecuteRequestFor<WorkflowDefinitionViewModel>(request);
        }
    }
}
