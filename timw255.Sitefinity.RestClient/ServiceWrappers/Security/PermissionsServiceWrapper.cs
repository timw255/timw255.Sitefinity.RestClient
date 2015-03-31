using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Security.Web.Services;
using Telerik.Sitefinity.Web.Services;
using Telerik.Sitefinity.Web.UI.Modules.Selectors;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Security
{
    public class PermissionsServiceWrapper : ServiceWrapper
    {
        public PermissionsServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Security/Permissions.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/ChangeInheritance/?dataProviderName={providerName}&managerClassName={managerTypeName}&securedObjectID={securedObjectIdString}&securedObjectType={securedObjectTypeName}&break={breakInheritance}&loseCustomChanges={loseCustomChanges}&transactionName={transactionName}&dynamicDataProviderName={dynamicDataProviderName}")]
        public PermissionSetCollectionContext ChangeInheritance(Guid securedObjectId, string securedObjectTypeName, string managerTypeName, string providerName, string breakInheritance, string loseCustomChanges, string transactionName, string dynamicDataProviderName)
        {
            var request = new RestRequest(this.ServiceUrl + "/ChangeInheritance/?dataProviderName={providerName}&managerClassName={managerTypeName}&securedObjectID={securedObjectId}&securedObjectType={securedObjectTypeName}&break={breakInheritance}&loseCustomChanges={loseCustomChanges}&transactionName={transactionName}&dynamicDataProviderName={dynamicDataProviderName}", Method.PUT);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("managerTypeName", managerTypeName);
            request.AddUrlSegment("securedObjectId", securedObjectId.ToString());
            request.AddUrlSegment("securedObjectTypeName", securedObjectTypeName);
            request.AddUrlSegment("breakInheritance", breakInheritance);
            request.AddUrlSegment("loseCustomChanges", loseCustomChanges);
            request.AddUrlSegment("transactionName", transactionName);
            request.AddUrlSegment("dynamicDataProviderName", dynamicDataProviderName);

            return ExecuteRequestFor<PermissionSetCollectionContext>(request);
        }

        //[WebGet(UriTemplate = "/GetManagerProviders/?managerClassName={managerClassName}")]
        public CollectionContext<ModuleProvider> GetManagerProviders(string managerClassName)
        {
            var request = new RestRequest(this.ServiceUrl + "/GetManagerProviders/?managerClassName={managerClassName}", Method.GET);

            request.AddUrlSegment("managerClassName", managerClassName);

            return ExecuteRequestFor<CollectionContext<ModuleProvider>>(request);
        }

        //[WebGet(UriTemplate = "/GetModuleProviders/?moduleName={moduleName}")]
        public CollectionContext<ModuleProvider> GetModuleProviders(string moduleName)
        {
            var request = new RestRequest(this.ServiceUrl + "/GetModuleProviders/?moduleName={moduleName}", Method.GET);

            request.AddUrlSegment("moduleName", moduleName);

            return ExecuteRequestFor<CollectionContext<ModuleProvider>>(request);
        }

        //[WebGet(UriTemplate = "/GetModules/?dataProviderName={dataProviderName}&securedObjectID={securedObjectID}&managerClassName={managerClassName}")]
        public CollectionContext<WcfPermissionModule> GetModules(string dataProviderName, string managerClassName, string securedObjectID)
        {
            var request = new RestRequest(this.ServiceUrl + "/GetModules/?dataProviderName={dataProviderName}&securedObjectID={securedObjectID}&managerClassName={managerClassName}", Method.GET);

            request.AddUrlSegment("dataProviderName", dataProviderName);
            request.AddUrlSegment("securedObjectID", securedObjectID);
            request.AddUrlSegment("managerClassName", managerClassName);

            return ExecuteRequestFor<CollectionContext<WcfPermissionModule>>(request);
        }

        //[WebGet(UriTemplate = "/GetPermissionSets/?permissionsSetName={permissionsSetName}&dataProviderName={dataProviderName}&managerClassName={managerClassName}&principalID={principalID}&securedObjectID={securedObjectID}&securedObjectType={securedObjectType}&dynamicDataProviderName={dynamicDataProviderName}")]
        public PermissionSetCollectionContext GetPermissionSetsForSpecificPrincipal(string permissionsSetName, string dataProviderName, string managerClassName, string principalID, string securedObjectID, string securedObjectType, string dynamicDataProviderName)
        {
            var request = new RestRequest(this.ServiceUrl + "/GetPermissionSets/?permissionsSetName={permissionsSetName}&dataProviderName={dataProviderName}&managerClassName={managerClassName}&principalID={principalID}&securedObjectID={securedObjectID}&securedObjectType={securedObjectType}&dynamicDataProviderName={dynamicDataProviderName}", Method.GET);

            request.AddUrlSegment("permissionsSetName", permissionsSetName);
            request.AddUrlSegment("dataProviderName", dataProviderName);
            request.AddUrlSegment("managerClassName", managerClassName);
            request.AddUrlSegment("principalID", principalID);
            request.AddUrlSegment("securedObjectID", securedObjectID);
            request.AddUrlSegment("securedObjectType", securedObjectType);
            request.AddUrlSegment("dynamicDataProviderName", dynamicDataProviderName);

            return ExecuteRequestFor<PermissionSetCollectionContext>(request);
        }

        //[WebGet(UriTemplate = "/?permissionsSetName={commaDelimitedPermissionsSetNames}&dataProviderName={dataProviderName}&managerClassName={managerClassName}&securedObjectID={securedObjectID}&securedObjectType={securedObjectType}&dynamicDataProviderName={dynamicDataProviderName}")]
        public PermissionSetCollectionContext GetPermissionsForSecuredObject(string commaDelimitedPermissionsSetNames, string dataProviderName, string managerClassName, string securedObjectID, string securedObjectType, string dynamicDataProviderName)
        {
            var request = new RestRequest(this.ServiceUrl + "/?permissionsSetName={commaDelimitedPermissionsSetNames}&dataProviderName={dataProviderName}&managerClassName={managerClassName}&securedObjectID={securedObjectID}&securedObjectType={securedObjectType}&dynamicDataProviderName={dynamicDataProviderName}", Method.GET);

            request.AddUrlSegment("commaDelimitedPermissionsSetNames", commaDelimitedPermissionsSetNames);
            request.AddUrlSegment("dataProviderName", dataProviderName);
            request.AddUrlSegment("managerClassName", managerClassName);
            request.AddUrlSegment("securedObjectID", securedObjectID);
            request.AddUrlSegment("securedObjectType", securedObjectType);
            request.AddUrlSegment("dynamicDataProviderName", dynamicDataProviderName);

            return ExecuteRequestFor<PermissionSetCollectionContext>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{permissionsSetName}/{dataProviderName}/?permissionObjectRootID={permissionObjectRootID}&managerClassName={managerClassName}&principalID={principalID}&securedObjectID={securedObjectID}&securedObjectType={securedObjectType}&dynamicDataProviderName={dynamicDataProviderName}")]
        public void SavePermissionActionsForSpecificPrincipal(List<WcfPermission> principals, string permissionsSetName, string dataProviderName, string permissionObjectRootID, string managerClassName, Guid principalID, string securedObjectID, string securedObjectType, string dynamicDataProviderName)
        {
            var request = new RestRequest(this.ServiceUrl + "/{permissionsSetName}/{dataProviderName}/?permissionObjectRootID={permissionObjectRootID}&managerClassName={managerClassName}&principalID={principalID}&securedObjectID={securedObjectID}&securedObjectType={securedObjectType}&dynamicDataProviderName={dynamicDataProviderName}", Method.PUT);

            request.AddUrlSegment("permissionsSetName", permissionsSetName);
            request.AddUrlSegment("dataProviderName", dataProviderName);
            request.AddUrlSegment("permissionObjectRootID", permissionObjectRootID);
            request.AddUrlSegment("managerClassName", managerClassName);
            request.AddUrlSegment("principalID", principalID.ToString());
            request.AddUrlSegment("securedObjectID", securedObjectID);
            request.AddUrlSegment("securedObjectType", securedObjectType);
            request.AddUrlSegment("dynamicDataProviderName", dynamicDataProviderName);

            request.AddParameter("application/json", SerializeObject(principals), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{permissionsSetName}/{dataProviderName}/{actionName}/?permissionObjectRootID={permissionObjectRootID}&managerClassName={managerClassName}&securedObjectID={securedObjectID}&securedObjectType={securedObjectType}&dynamicDataProviderName={dynamicDataProviderName}")]
        public void SavePermissionsForSpecificAction(List<WcfPermission> principals, string permissionsSetName, string dataProviderName, string permissionObjectRootID, string actionName, string managerClassName, string securedObjectID, string securedObjectType, string dynamicDataProviderName)
        {
            var request = new RestRequest(this.ServiceUrl + "/{permissionsSetName}/{dataProviderName}/{actionName}/?permissionObjectRootID={permissionObjectRootID}&managerClassName={managerClassName}&securedObjectID={securedObjectID}&securedObjectType={securedObjectType}&dynamicDataProviderName={dynamicDataProviderName}", Method.PUT);

            request.AddUrlSegment("permissionsSetName", permissionsSetName);
            request.AddUrlSegment("dataProviderName", dataProviderName);
            request.AddUrlSegment("actionName", actionName);
            request.AddUrlSegment("permissionObjectRootID", permissionObjectRootID);
            request.AddUrlSegment("managerClassName", managerClassName);
            request.AddUrlSegment("securedObjectID", securedObjectID);
            request.AddUrlSegment("securedObjectType", securedObjectType);
            request.AddUrlSegment("dynamicDataProviderName", dynamicDataProviderName);

            request.AddParameter("application/json", SerializeObject(principals), ParameterType.RequestBody);

            ExecuteRequest(request);
        }
    }
}
