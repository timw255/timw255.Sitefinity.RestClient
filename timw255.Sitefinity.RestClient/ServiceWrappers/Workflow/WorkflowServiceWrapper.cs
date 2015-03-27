using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Workflow.Services.Data;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Workflow
{
    public class WorkflowServiceWrapper : ServiceWrapper
    {
        public WorkflowServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Workflow/WorkflowService.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate = "/{itemId}/?itemType={itemType}&providerName={providerName}&itemCulture={itemCulture}&showMoreActions={showMoreActions}")]
        public WorkflowVisualElementsCollection GetWorkflowVisualElements(string itemType, string providerName, Guid itemId, string itemCulture, bool showMoreActions = true)
        {
            var request = new RestRequest(this.ServiceUrl + "/{itemId}/?itemType={itemType}&providerName={providerName}&itemCulture={itemCulture}&showMoreActions={showMoreActions}", Method.GET);

            request.AddUrlSegment("itemId", itemId.ToString());
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("itemCulture", itemCulture);
            request.AddUrlSegment("showMoreActions", showMoreActions.ToString());

            return ExecuteRequestFor<WorkflowVisualElementsCollection>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/MessageWorkflow/{itemId}/?itemType={itemType}&providerName={providerName}&workflowOperation={workflowOperation}")]
        public string MessageWorkflow(KeyValuePair<string, string>[] contextBag, Guid itemId, string itemType, string providerName, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "/MessageWorkflow/{itemId}/?itemType={itemType}&providerName={providerName}&workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("itemId", itemId.ToString());
            request.AddUrlSegment("itemType", itemType);
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(contextBag), ParameterType.RequestBody);

            return ExecuteRequestFor<string>(request);
        }
    }
}
