using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Configuration
{
    public class ConfigSectionItemsServiceWrapper : ServiceWrapper
    {
        public ConfigSectionItemsServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Configuration/ConfigSectionItems.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "?nodeName={nodeName}&policyHandlerName={policyHandlerName}&policyName={policyName}&provider={provider}&mode={mode}")]
        public bool DeleteSection(string nodeName, string policyHandlerName, string policyName, string provider, string mode)
        {
            var request = new RestRequest(this.ServiceUrl + "?nodeName={nodeName}&policyHandlerName={policyHandlerName}&policyName={policyName}&provider={provider}&mode={mode}", Method.DELETE);

            request.AddUrlSegment("nodeName", nodeName);
            request.AddUrlSegment("policyHandlerName", policyHandlerName);
            request.AddUrlSegment("policyName", policyName);
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("mode", mode);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "texteditor/batch/")]
        public void DeleteTextEditorToolsets(string[] keys)
        {
            var request = new RestRequest(this.ServiceUrl + "texteditor/batch/", Method.POST);

            request.AddParameter("application/json", SerializeObject(keys), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "authentication/")]
        public UserAuthenticationSettingsContract GetAuthenticationModeSettings()
        {
            var request = new RestRequest(this.ServiceUrl + "authentication/", Method.GET);

            return ExecuteRequest<UserAuthenticationSettingsContract>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "comments/")]
        public CommentsSettingsContract GetCommentsBasicSettings()
        {
            var request = new RestRequest(this.ServiceUrl + "comments/", Method.GET);

            return ExecuteRequest<CommentsSettingsContract>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "?nodeName={nodeName}&policyHandlerName={policyHandlerName}&policyName={policyName}&provider={provider}&mode={mode}&type={typeName}")]
        public CollectionContext<UISectionItem> GetConfigSetionItems(string nodeName, string policyHandlerName, string policyName, string provider, string mode, string typeName)
        {
            var request = new RestRequest(this.ServiceUrl + "?nodeName={nodeName}&policyHandlerName={policyHandlerName}&policyName={policyName}&provider={provider}&mode={mode}&type={typeName}", Method.GET);

            request.AddUrlSegment("nodeName", nodeName);
            request.AddUrlSegment("policyHandlerName", policyHandlerName);
            request.AddUrlSegment("policyName", policyName);
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("mode", mode);
            request.AddUrlSegment("typeName", typeName);

            return ExecuteRequest<CollectionContext<UISectionItem>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "cultures/?filter={filter}")]
        public CollectionContext<CultureViewModel> GetCultures(string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "cultures/?filter={filter}", Method.GET);

            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<CultureViewModel>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "general/?siteId={siteId}")]
        public GeneralSettingsModel GetGeneralBasicSettings(Guid siteId)
        {
            var request = new RestRequest(this.ServiceUrl + "general/?siteId={siteId}", Method.GET);

            request.AddUrlSegment("siteId", siteId.ToString());

            return ExecuteRequest<GeneralSettingsModel>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "languages/?filter={filter}")]
        public CollectionContext<CultureViewModel> GetLanguages(string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "languages/?filter={filter}", Method.GET);

            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<CultureViewModel>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "localization/?includeSitesNames={includeSitesNames}")]
        public LocalizationSettingsModel GetLocalizationBasicSettings(bool includeSitesNames)
        {
            var request = new RestRequest(this.ServiceUrl + "localization/?includeSitesNames={includeSitesNames}", Method.GET);

            request.AddUrlSegment("includeSitesNames", includeSitesNames.ToString());

            return ExecuteRequest<LocalizationSettingsModel>(request);
        }

        //[WebGet(UriTemplate = "/newsletters/")]
        public NewslettersSettingsContract GetNewslettersBasicSettings()
        {
            var request = new RestRequest(this.ServiceUrl + "/newsletters/", Method.GET);

            return ExecuteRequest<NewslettersSettingsContract>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "socialshare/")]
        public SocialShareSettingsContract GetSocialShareBasicSettings()
        {
            var request = new RestRequest(this.ServiceUrl + "socialshare/", Method.GET);

            return ExecuteRequest<SocialShareSettingsContract>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "texteditortoolset/?toolSetName={toolSetName}")]
        public CollectionContext<TextEditorToolsetViewModel> GetTextEditorToolset(string toolSetName)
        {
            var request = new RestRequest(this.ServiceUrl + "texteditortoolset/?toolSetName={toolSetName}", Method.GET);

            request.AddUrlSegment("toolSetName", toolSetName);

            return ExecuteRequest<CollectionContext<TextEditorToolsetViewModel>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "texteditor/?getDefault={getDefault}")]
        public CollectionContext<TextEditorToolsetViewModel> GetTextEditorToolsets(bool getDefault)
        {
            var request = new RestRequest(this.ServiceUrl + "texteditor/?getDefault={getDefault}", Method.GET);

            request.AddUrlSegment("getDefault", getDefault.ToString());

            return ExecuteRequest<CollectionContext<TextEditorToolsetViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "authentication/{key}/")]
        public void SaveAuthenticationMode(ItemContext<UserAuthenticationSettingsContract> settings, string key)
        {
            var request = new RestRequest(this.ServiceUrl + "authentication/{key}/", Method.PUT);

            request.AddUrlSegment("key", key);

            request.AddParameter("application/json", SerializeObject(settings), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "batch/?nodeName={nodeName}&policyHandlerName={policyHandlerName}&policyName={policyName}&provider={provider}&mode={mode}&type={typeName}")]
        public bool SaveBatchConfigSection(string[][] propertyBag, string nodeName, string policyHandlerName, string policyName, string provider, string mode, string typeName)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/?nodeName={nodeName}&policyHandlerName={policyHandlerName}&policyName={policyName}&provider={provider}&mode={mode}&type={typeName}", Method.PUT);

            request.AddUrlSegment("nodeName", nodeName);
            request.AddUrlSegment("policyHandlerName", policyHandlerName);
            request.AddUrlSegment("policyName", policyName);
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("mode", mode);
            request.AddUrlSegment("typeName", typeName);

            request.AddParameter("application/json", SerializeObject(propertyBag), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "comments/{key}/")]
        public void SaveCommentsBasicSettings(ItemContext<CommentsSettingsContract> settings, string key)
        {
            var request = new RestRequest(this.ServiceUrl + "comments/{key}/", Method.PUT);

            request.AddUrlSegment("key", key);

            request.AddParameter("application/json", SerializeObject(settings), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "general/{key}/")]
        public void SaveGeneralBasicSettings(ItemContext<GeneralSettingsModel> settings, string key)
        {
            var request = new RestRequest(this.ServiceUrl + "general/{key}/", Method.PUT);

            request.AddUrlSegment("key", key);

            request.AddParameter("application/json", SerializeObject(settings), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "localization/{key}/")]
        public void SaveLocalizationBasicSettings(ItemContext<LocalizationSettingsModel> settings, string key)
        {
            var request = new RestRequest(this.ServiceUrl + "localization/{key}/", Method.PUT);

            request.AddUrlSegment("key", key);

            request.AddParameter("application/json", SerializeObject(settings), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/newsletters/{key}/")]
        public void SaveNewslettersBasicSettings(ItemContext<NewslettersSettingsContract> settings, string key)
        {
            var request = new RestRequest(this.ServiceUrl + "/newsletters/{key}/", Method.PUT);

            request.AddUrlSegment("key", key);

            request.AddParameter("application/json", SerializeObject(settings), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "socialshare/{key}/")]
        public void SaveSocialShareBasicSettings(ItemContext<SocialShareSettingsContract> settings, string key)
        {
            var request = new RestRequest(this.ServiceUrl + "socialshare/{key}/", Method.PUT);

            request.AddUrlSegment("key", key);

            request.AddParameter("application/json", SerializeObject(settings), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "texteditor/{key}/")]
        public string SaveTextEditorToolsets(TextEditorToolsetViewModel toolSet, string key)
        {
            var request = new RestRequest(this.ServiceUrl + "texteditor/{key}/", Method.PUT);

            request.AddUrlSegment("key", key);

            request.AddParameter("application/json", SerializeObject(toolSet), ParameterType.RequestBody);

            return ExecuteRequest<string>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "texteditorupload/")]
        public string UploadTextEditorToolset()
        {
            var request = new RestRequest(this.ServiceUrl + "texteditorupload/", Method.POST);

            return ExecuteRequest<string>(request);
        }
    }
}
