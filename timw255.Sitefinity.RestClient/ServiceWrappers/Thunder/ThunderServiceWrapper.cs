using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Thunder
{
    public class ThunderServiceWrapper : ServiceWrapper
    {
        public ThunderServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Thunder/ThunderService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/Authenticate")]
        public AuthenticationResult AuthenticateUser(AuthenticationCredentials credentials)
        {
            var request = new RestRequest(this.ServiceUrl + "/Authenticate", Method.POST);

            request.AddParameter("application/json", SerializeObject(credentials), ParameterType.RequestBody);

            return ExecuteRequest<AuthenticationResult>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/CodeDeploy/CheckSetup")]
        public bool CheckCodeDeploySetup()
        {
            var request = new RestRequest(this.ServiceUrl + "/CodeDeploy/CheckSetup", Method.GET);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/CodeSync/CheckSetup")]
        public bool CheckCodeSyncSetup()
        {
            var request = new RestRequest(this.ServiceUrl + "/CodeSync/CheckSetup", Method.GET);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/CodeSync/CheckLicense")]
        public bool CheckLicense()
        {
            var request = new RestRequest(this.ServiceUrl + "/CodeSync/CheckLicense", Method.GET);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/Theme/{type}/{themeName}/{createBackup}")]
        public bool DeleteTheme(string themeName, string type, string createBackup)
        {
            var request = new RestRequest(this.ServiceUrl + "/Theme/{type}/{themeName}/{createBackup}", Method.DELETE);

            request.AddUrlSegment("type", type);
            request.AddUrlSegment("themeName", themeName);
            request.AddUrlSegment("createBackup", createBackup);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/WebsiteTemplate/{templateName}/{createBackup}")]
        public bool DeleteWebsiteTemplate(string templateName, string createBackup)
        {
            var request = new RestRequest(this.ServiceUrl + "/WebsiteTemplate/{templateName}/{createBackup}", Method.DELETE);

            request.AddUrlSegment("templateName", templateName);
            request.AddUrlSegment("createBackup", createBackup);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/WidgetTemplates/{id}?providerName={providerName}")]
        public bool DeleteWidgetTemplate(Guid id, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/WidgetTemplates/{id}?providerName={providerName}", Method.DELETE);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/Pages/GetBackendMenuPageSections")]
        public ThunderPageSiteNode GetBackendMenuPageSections()
        {
            var request = new RestRequest(this.ServiceUrl + "/Pages/GetBackendMenuPageSections", Method.GET);

            return ExecuteRequest<ThunderPageSiteNode>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/CssClasses/{themeName}?isBackend={isBackend}")]
        public IEnumerable<string> GetCssClasses(string themeName, bool isBackend)
        {
            var request = new RestRequest(this.ServiceUrl + "/CssClasses/{themeName}?isBackend={isBackend}", Method.GET);

            request.AddUrlSegment("themeName", themeName);
            request.AddUrlSegment("isBackend", isBackend.ToString());

            return ExecuteRequest<IEnumerable<string>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/DynamicModules")]
        public IEnumerable<ThunderDynamicModule> GetDynamicModules()
        {
            var request = new RestRequest(this.ServiceUrl + "/DynamicModules", Method.GET);

            return ExecuteRequest<IEnumerable<ThunderDynamicModule>>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/MasterPages/GetData")]
        public MasterPageFile GetMasterPageData(MasterPageFile masterPage)
        {
            var request = new RestRequest(this.ServiceUrl + "/MasterPages/GetData", Method.POST);

            request.AddParameter("application/json", SerializeObject(masterPage), ParameterType.RequestBody);

            return ExecuteRequest<MasterPageFile>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/CodeSync/ServerSyncShot")]
        public SyncShot GetServerSyncShot()
        {
            var request = new RestRequest(this.ServiceUrl + "/CodeSync/ServerSyncShot", Method.GET);

            return ExecuteRequest<SyncShot>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/CodeSync/ServerSyncShotWithSyncItemById/{Id}")]
        public SyncShot GetServerSyncShotWithSyncItemById(Guid id)
        {
            var request = new RestRequest(this.ServiceUrl + "/CodeSync/ServerSyncShotWithSyncItemById/{Id}", Method.GET);

            request.AddUrlSegment("Id", id.ToString());

            return ExecuteRequest<SyncShot>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/CodeSync/GetData")]
        public Stream GetSyncData(SyncDataInfo dataInfo)
        {
            var request = new RestRequest(this.ServiceUrl + "/CodeSync/GetData", Method.PUT);

            request.AddParameter("application/json", SerializeObject(dataInfo), ParameterType.RequestBody);

            return ExecuteRequest<Stream>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/SystemInfo")]
        public SitefinitySystemInfo GetSystemInfo()
        {
            var request = new RestRequest(this.ServiceUrl + "/SystemInfo", Method.GET);

            return ExecuteRequest<SitefinitySystemInfo>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/Themes/{type}/{themeName}?includeData={includeData}")]
        public Theme GetTheme(string themeName, string type, bool includeData)
        {
            var request = new RestRequest(this.ServiceUrl + "/Themes/{type}/{themeName}?includeData={includeData}", Method.GET);

            request.AddUrlSegment("type", type);
            request.AddUrlSegment("themeName", themeName);
            request.AddUrlSegment("includeData", includeData.ToString());

            return ExecuteRequest<Theme>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/Themes")]
        public ICollection<Theme> GetThemes()
        {
            var request = new RestRequest(this.ServiceUrl + "/Themes", Method.GET);

            return ExecuteRequest<ICollection<Theme>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/WebsiteTemplate/{templateName}?includeData={includeData}")]
        public WebsiteTemplate GetWebsiteTemplate(string templateName, bool includeData)
        {
            var request = new RestRequest(this.ServiceUrl + "/WebsiteTemplate/{templateName}?includeData={includeData}", Method.GET);

            request.AddUrlSegment("templateName", templateName);
            request.AddUrlSegment("includeData", includeData.ToString());

            return ExecuteRequest<WebsiteTemplate>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/WebsiteTemplates")]
        public IEnumerable<WebsiteTemplate> GetWebsiteTemplates()
        {
            var request = new RestRequest(this.ServiceUrl + "/WebsiteTemplates", Method.GET);

            return ExecuteRequest<IEnumerable<WebsiteTemplate>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/WidgetProperties/{controlType}")]
        public ICollection<DataItemProperty> GetWidgetProperties(string controlType)
        {
            var request = new RestRequest(this.ServiceUrl + "/WidgetProperties/{controlType}", Method.GET);

            request.AddUrlSegment("controlType", controlType);

            return ExecuteRequest<ICollection<DataItemProperty>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/CodeDeploy/WidgetSections/{widgetType}")]
        public ICollection<string> GetWidgetSections(string widgetType)
        {
            var request = new RestRequest(this.ServiceUrl + "/CodeDeploy/WidgetSections/{widgetType}", Method.GET);

            request.AddUrlSegment("widgetType", widgetType);

            return ExecuteRequest<ICollection<string>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/WidgetTemplates/{id}?providerName={providerName}")]
        public WidgetTemplate GetWidgetTemplate(Guid id, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/WidgetTemplates/{id}?providerName={providerName}", Method.GET);

            request.AddUrlSegment("id", id.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<WidgetTemplate>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/WidgetTemplates?providerName={providerName}")]
        public ICollection<WidgetTemplate> GetWidgetTemplates(string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/WidgetTemplates?providerName={providerName}", Method.GET);

            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<ICollection<WidgetTemplate>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/IsCurrentUserAuthenticated")]
        public bool IsCurrentUserAuthenticated()
        {
            var request = new RestRequest(this.ServiceUrl + "/IsCurrentUserAuthenticated", Method.GET);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/LogoutWithCredentials")]
        public bool LogoutWithCredentials(AuthenticationCredentials credentials)
        {
            var request = new RestRequest(this.ServiceUrl + "/LogoutWithCredentials", Method.POST);

            request.AddParameter("application/json", SerializeObject(credentials), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/MasterPages/Save")]
        public bool SaveMasterPage(MasterPageFile masterPage)
        {
            var request = new RestRequest(this.ServiceUrl + "/MasterPages/Save", Method.POST);

            request.AddParameter("application/json", SerializeObject(masterPage), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/Theme/Save/{type}/{themeName}/{templateName}/{createBackup}")]
        public bool SaveTheme(string themeName, string templateName, string type, string createBackup, Stream themeData)
        {
            var request = new RestRequest(this.ServiceUrl + "/Theme/Save/{type}/{themeName}/{templateName}/{createBackup}", Method.PUT);

            request.AddUrlSegment("type", type);
            request.AddUrlSegment("themeName", themeName);
            request.AddUrlSegment("templateName", templateName);
            request.AddUrlSegment("createBackup", createBackup);

            request.AddParameter("application/json", SerializeObject(themeData), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/WebsiteTemplate/Save/{templateName}/{createBackup}")]
        public bool SaveWebsiteTemplate(string templateName, string createBackup, Stream templateDataStream)
        {
            var request = new RestRequest(this.ServiceUrl + "/WebsiteTemplate/Save/{templateName}/{createBackup}", Method.PUT);

            request.AddUrlSegment("templateName", templateName);
            request.AddUrlSegment("createBackup", createBackup);

            request.AddParameter("application/json", SerializeObject(templateDataStream), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/WidgetTemplates/Save?providerName={providerName}")]
        public bool SaveWidgetTemplate(WidgetTemplate widgetTemplate, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "/WidgetTemplates/Save?providerName={providerName}", Method.POST);

            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", SerializeObject(widgetTemplate), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/CodeDeploy/SendData/{infoBytesCountString}")]
        public bool SendDeployData(string infoBytesCountString, Stream dataStream)
        {
            var request = new RestRequest(this.ServiceUrl + "/CodeDeploy/SendData/{infoBytesCountString}", Method.PUT);

            request.AddUrlSegment("infoBytesCountString", infoBytesCountString);

            request.AddParameter("application/json", SerializeObject(dataStream), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/CodeSync/SendData/{infoBytesCountString}")]
        public List<FailedToSyncItem> SendSyncData(string infoBytesCountString, Stream dataStream)
        {
            var request = new RestRequest(this.ServiceUrl + "/CodeSync/SendData/{infoBytesCountString}", Method.PUT);

            request.AddUrlSegment("infoBytesCountString", infoBytesCountString);

            request.AddParameter("application/json", SerializeObject(dataStream), ParameterType.RequestBody);

            return ExecuteRequest<List<FailedToSyncItem>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/TestConnection")]
        public bool TestConnection()
        {
            var request = new RestRequest(this.ServiceUrl + "/TestConnection", Method.GET);

            return ExecuteRequest<bool>(request);
        }
    }
}
