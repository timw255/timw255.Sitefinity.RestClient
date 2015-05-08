using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.UserProfiles
{
    public class UserProfileTypesServiceWrapper : ServiceWrapper
    {
        public UserProfileTypesServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/UserProfiles/UserProfileTypesService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "batch/?providerName={providerName}")]
        public bool BatchDeleteUserProfileTypes(Guid[] Ids, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "batch/?providerName={providerName}", Method.POST);

            request.AddUrlSegment("providerName", providerName);

            request.AddParameter("application/json", SerializeObject(Ids), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "{profileTypeId}/?providerName={providerName}")]
        public bool DeleteUserProfileType(Guid profileTypeId, string providerName)
        {
            var request = new RestRequest(this.ServiceUrl + "{profileTypeId}/?providerName={providerName}", Method.DELETE);

            request.AddUrlSegment("profileTypeId", profileTypeId.ToString());
            request.AddUrlSegment("providerName", providerName);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/{userId}")]
        public string GetAllProfilesForUser(Guid userId)
        {
            var request = new RestRequest(this.ServiceUrl + "/{userId}", Method.GET);

            request.AddUrlSegment("userId", userId.ToString());

            return ExecuteRequest<string>(request);
        }

        //[WebGet(UriTemplate = "{profileTypeId}/?providerName={providerName}&duplicate={duplicate}")]
        public UserProfileTypeContext GetUserProfileType(Guid profileTypeId, string providerName, bool duplicate)
        {
            var request = new RestRequest(this.ServiceUrl + "{profileTypeId}/?providerName={providerName}&duplicate={duplicate}", Method.GET);

            request.AddUrlSegment("profileTypeId", profileTypeId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("duplicate", duplicate.ToString());

            return ExecuteRequest<UserProfileTypeContext>(request);
        }

        //[WebGet(UriTemplate = "?userProfilesFilter={userProfilesFilter}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&root={root}")]
        public CollectionContext<UserProfileTypeViewModel> GetUserProfileTypes(string userProfilesFilter, string sortExpression, int skip, int take, string filter, string root)
        {
            var request = new RestRequest(this.ServiceUrl + "?userProfilesFilter={userProfilesFilter}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&root={root}", Method.GET);

            request.AddUrlSegment("userProfilesFilter", userProfilesFilter);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("root", root);

            return ExecuteRequest<CollectionContext<UserProfileTypeViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "{userId}")]
        public string SaveAllProfilesForUser(string profileData, Guid userId)
        {
            var request = new RestRequest(this.ServiceUrl + "{userId}", Method.PUT);

            request.AddUrlSegment("userId", userId.ToString());

            request.AddParameter("application/json", SerializeObject(profileData), ParameterType.RequestBody);

            return ExecuteRequest<string>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "{profileTypeId}/?providerName={providerName}&duplicate={duplicate}")]
        public UserProfileTypeContext SaveUserProfileType(UserProfileTypeContext profileTypeDataContext, Guid profileTypeId, string providerName, bool duplicate)
        {
            var request = new RestRequest(this.ServiceUrl + "{profileTypeId}/?providerName={providerName}&duplicate={duplicate}", Method.PUT);

            request.AddUrlSegment("profileTypeId", profileTypeId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("duplicate", duplicate.ToString());

            request.AddParameter("application/json", SerializeObject(profileTypeDataContext), ParameterType.RequestBody);

            return ExecuteRequest<UserProfileTypeContext>(request);
        }
    }
}
