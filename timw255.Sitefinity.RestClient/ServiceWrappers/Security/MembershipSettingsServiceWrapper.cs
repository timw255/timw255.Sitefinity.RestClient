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

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers.Security
{
    public class MembershipSettingsServiceWrapper : ServiceWrapper
    {
        public MembershipSettingsServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Security/MembershipSettings.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/changePassword/{userId}/?provider={provider}")]
        public void ChangePassword(WcfPasswordChangeData passwordChangeData, Guid userId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/changePassword/{userId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("userId", userId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(passwordChangeData), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebGet(UriTemplate = "{provider=null}/?")]
        public MembershipProviderSetting GetMembershipProvider(string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{provider}/?", Method.GET);

            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<MembershipProviderSetting>(request);
        }

        //[WebGet(UriTemplate = "getRolesForUser/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<UserRolesItem> GetRolesForUsers(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "getRolesForUser/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<UserRolesItem>>(request);
        }

        //[WebGet(UriTemplate = "recoverPassword/{username}/?provider={provider}&answer={answer}")]
        public string RecoverPasswordOfUser(string username, string provider, string answer)
        {
            var request = new RestRequest(this.ServiceUrl + "recoverPassword/{username}/?provider={provider}&answer={answer}", Method.GET);

            request.AddUrlSegment("username", username);
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("answer", answer);

            return ExecuteRequestFor<string>(request);
        }
    }
}
