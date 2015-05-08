using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Pages
{
    public class ZoneEditorServiceWrapper : ServiceWrapper
    {
        public ZoneEditorServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Pages/ZoneEditorService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Template/changeTemplate/{draftId}/?newTemplateId={newTemplateId}")]
        public bool ChangeParentTemplate(Guid draftId, Guid newTemplateId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Template/changeTemplate/{draftId}/?newTemplateId={newTemplateId}", Method.PUT);

            request.AddUrlSegment("draftId", draftId.ToString());
            request.AddUrlSegment("newTemplateId", newTemplateId.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/changeTemplate/{pageId}/?newTemplateId={newTemplateId}")]
        public void ChangeTemplate(Guid pageId, Guid newTemplateId)
        {
            var request = new RestRequest(this.ServiceUrl + "/changeTemplate/{pageId}/?newTemplateId={newTemplateId}", Method.PUT);

            request.AddUrlSegment("pageId", pageId.ToString());
            request.AddUrlSegment("newTemplateId", newTemplateId.ToString());

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Page/Theme/{draftId}/?isTemplate={isTemplate}")]
        public bool ChangeTheme(Guid draftId, string themeName, bool isTemplate)
        {
            var request = new RestRequest(this.ServiceUrl + "/Page/Theme/{draftId}/?isTemplate={isTemplate}", Method.PUT);

            request.AddUrlSegment("draftId", draftId.ToString());
            request.AddUrlSegment("isTemplate", isTemplate.ToString());

            request.AddParameter("application/json", SerializeObject(themeName), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/Form/{draftId}/")]
        public bool DiscardFormDraft(Guid draftId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Form/{draftId}/", Method.DELETE);

            request.AddUrlSegment("draftId", draftId.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/Page/{draftId}/")]
        public bool DiscardPageDraft(Guid draftId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Page/{draftId}/", Method.DELETE);

            request.AddUrlSegment("draftId", draftId.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/Template/{draftId}/")]
        public bool DiscardTemplateDraft(Guid draftId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Template/{draftId}/", Method.DELETE);

            request.AddUrlSegment("draftId", draftId.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Page/InitializeSplitPage/?sourceLanguage={sourceLanguage}&targetLanguage={targetLanguage}")]
        public void InitializeSplitPage(Guid targetNodeId, string sourceLanguage, string targetLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/Page/InitializeSplitPage/?sourceLanguage={sourceLanguage}&targetLanguage={targetLanguage}", Method.PUT);

            request.AddUrlSegment("sourceLanguage", sourceLanguage);
            request.AddUrlSegment("targetLanguage", targetLanguage);

            request.AddParameter("application/json", SerializeObject(targetNodeId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Form/Publish/{draftId}/")]
        public bool PublishFormDraft(FormDescriptionViewModel formViewModel, Guid draftId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Form/Publish/{draftId}/", Method.PUT);

            request.AddUrlSegment("draftId", draftId.ToString());

            request.AddParameter("application/json", SerializeObject(formViewModel), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Page/Publish/")]
        public bool PublishPageDraft(Guid draftId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Page/Publish/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(draftId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Template/Publish/")]
        public bool PublishTemplateDraft(Guid draftId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Template/Publish/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(draftId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "rollback/")]
        public ZoneEditorWebServiceArgs Rollback(ZoneEditorWebServiceArgs state)
        {
            var request = new RestRequest(this.ServiceUrl + "rollback/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(state), ParameterType.RequestBody);

            return ExecuteRequest<ZoneEditorWebServiceArgs>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Form/Save/{draftId}/")]
        public bool SaveFormDraft(FormDescriptionViewModel formViewModel, Guid draftId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Form/Save/{draftId}/", Method.PUT);

            request.AddUrlSegment("draftId", draftId.ToString());

            request.AddParameter("application/json", SerializeObject(formViewModel), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Page/Save/?workflowOperation={workflowOperation}")]
        public bool SavePageDraft(WcfPageData wcfPageData, string workflowOperation)
        {
            var request = new RestRequest(this.ServiceUrl + "/Page/Save/?workflowOperation={workflowOperation}", Method.PUT);

            request.AddUrlSegment("workflowOperation", workflowOperation);

            request.AddParameter("application/json", SerializeObject(wcfPageData), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Template/Save/")]
        public bool SaveTemplateDraft(Guid draftId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Template/Save/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(draftId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "setoverride/{editable}/")]
        public ZoneEditorWebServiceArgs SetOverride(ZoneEditorWebServiceArgs state, string editable)
        {
            var request = new RestRequest(this.ServiceUrl + "setoverride/{editable}/", Method.PUT);

            request.AddUrlSegment("editable", editable);

            request.AddParameter("application/json", SerializeObject(state), ParameterType.RequestBody);

            return ExecuteRequest<ZoneEditorWebServiceArgs>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Page/LocalizationStrategy/?strategy={strategy}&copyData={copyData}")]
        public void SetPageLocalizationStrategy(Guid pageNodeId, string strategy, bool copyData)
        {
            var request = new RestRequest(this.ServiceUrl + "/Page/LocalizationStrategy/?strategy={strategy}&copyData={copyData}", Method.PUT);

            request.AddUrlSegment("strategy", strategy);
            request.AddUrlSegment("copyData", copyData.ToString());

            request.AddParameter("application/json", SerializeObject(pageNodeId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Page/SplitPage/")]
        public void SplitPage(Guid pageNodeId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Page/SplitPage/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(pageNodeId), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/Page/TakeOwnership/{draftId}/")]
        public void TakePageOwnership(Guid draftId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Page/TakeOwnership/{draftId}/", Method.GET);

            request.AddUrlSegment("draftId", draftId.ToString());

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/Template/TakeOwnership/{draftId}/")]
        public void TemplateTakeOwnership(Guid draftId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Template/TakeOwnership/{draftId}/", Method.GET);

            request.AddUrlSegment("draftId", draftId.ToString());

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/Form/UnlockForm/{formId}/")]
        public void UnlockForm(Guid formId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Form/UnlockForm/{formId}/", Method.GET);

            request.AddUrlSegment("formId", formId.ToString());

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/Page/UnlockPage/{pageDataId}/")]
        public void UnlockPage(Guid pageDataId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Page/UnlockPage/{pageDataId}/", Method.GET);

            request.AddUrlSegment("pageDataId", pageDataId.ToString());

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/Template/UnlockTemplate/{templateId}/")]
        public void UnlockTemplate(Guid templateId)
        {
            var request = new RestRequest(this.ServiceUrl + "/Template/UnlockTemplate/{templateId}/", Method.GET);

            request.AddUrlSegment("templateId", templateId.ToString());

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Control/")]
        public ZoneEditorWebServiceArgs UpdateControlState(ZoneEditorWebServiceArgs state)
        {
            var request = new RestRequest(this.ServiceUrl + "/Control/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(state), ParameterType.RequestBody);

            return ExecuteRequest<ZoneEditorWebServiceArgs>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Layout/Style/{LayoutControlId}/{PageId}/{isTemplate}/")]
        public ZoneEditorWebServiceArgs UpdateLayoutControlStyles(ZoneEditorWebServiceArgs args, Guid layoutControlId, Guid pageId, string isTemplate)
        {
            var request = new RestRequest(this.ServiceUrl + "/Layout/Style/{LayoutControlId}/{PageId}/{isTemplate}/", Method.PUT);

            request.AddUrlSegment("LayoutControlId", layoutControlId.ToString());
            request.AddUrlSegment("PageId", pageId.ToString());
            request.AddUrlSegment("isTemplate", isTemplate);

            request.AddParameter("application/json", SerializeObject(args), ParameterType.RequestBody);

            return ExecuteRequest<ZoneEditorWebServiceArgs>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Layout/")]
        public ZoneEditorWebServiceArgs UpdateLayoutState(ZoneEditorWebServiceArgs state)
        {
            var request = new RestRequest(this.ServiceUrl + "/Layout/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(state), ParameterType.RequestBody);

            return ExecuteRequest<ZoneEditorWebServiceArgs>(request);
        }
    }
}
