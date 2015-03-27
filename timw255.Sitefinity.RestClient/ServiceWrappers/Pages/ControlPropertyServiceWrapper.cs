using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Modules.Pages.Web.Services;
using Telerik.Sitefinity.Modules.Pages.Web.Services.Model;
using Telerik.Sitefinity.Web.Services;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Pages
{
    public class ControlPropertyServiceWrapper : ServiceWrapper
    {
        public ControlPropertyServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Pages/ControlPropertyService.svc/";
            this.SF = sf;
        }

        //[WebGet(UriTemplate="/{controlId}/{propertyName=null}/?providerName={providerName}&skip={skip}&take={take}&sortExpression={sortExpression}", ResponseFormat=WebMessageFormat.Json)]
        public CollectionContext<WcfControlProperty> GetProperties(Guid controlId, string propertyName, string providerName, int skip, int take, string sortExpression)
        {
            var request = new RestRequest(this.ServiceUrl + "/{controlId}/{propertyName}/?providerName={providerName}&skip={skip}&take={take}&sortExpression={sortExpression}", Method.GET);

            request.AddUrlSegment("controlId", controlId.ToString());
            request.AddUrlSegment("propertyName", propertyName);
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("sortExpression", sortExpression);

            return ExecuteRequestFor<CollectionContext<WcfControlProperty>>(request);
        }

        //[WebInvoke(Method="PUT", UriTemplate="/batch/{controlId}/?providerName={providerName}&pageId={pageId}&mediaType={mediaType}&checkLiveVersion={checkLiveVersion}&upgradePageVersion={upgradePageVersion}&propertyLocalization={propertyLocalization}&isOpenedByBrowseAndEdit={isOpenedByBrowseAndEdit}", ResponseFormat=WebMessageFormat.Json)]
        public void SaveProperties(WcfControlProperty[] properties, Guid controlId, string providerName, Guid pageId, string mediaType, bool checkLiveVersion = false, bool upgradePageVersion = false, PropertyLocalizationType propertyLocalization = 0, bool isOpenedByBrowseAndEdit = false)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/{controlId}/?providerName={providerName}&pageId={pageId}&mediaType={mediaType}&checkLiveVersion={checkLiveVersion}&upgradePageVersion={upgradePageVersion}&propertyLocalization={propertyLocalization}&isOpenedByBrowseAndEdit={isOpenedByBrowseAndEdit}", Method.PUT);

            request.AddUrlSegment("controlId", controlId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("pageId", pageId.ToString());
            request.AddUrlSegment("mediaType", mediaType);
            request.AddUrlSegment("checkLiveVersion", checkLiveVersion.ToString());
            request.AddUrlSegment("upgradePageVersion", upgradePageVersion.ToString());
            request.AddUrlSegment("propertyLocalization", propertyLocalization.ToString());
            request.AddUrlSegment("isOpenedByBrowseAndEdit", isOpenedByBrowseAndEdit.ToString());

            request.AddParameter("application/json", SerializeObject(properties), ParameterType.RequestBody);

            ExecuteRequest(request);
        }
    }
}
