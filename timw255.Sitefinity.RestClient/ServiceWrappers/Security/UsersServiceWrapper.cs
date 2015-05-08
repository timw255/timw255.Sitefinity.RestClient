using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Security
{
    public class UsersServiceWrapper : ServiceWrapper
    {
        public UsersServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Security/Users.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/Authenticate")]
        public UserLoggingReason AuthenticateUser(Credentials credentials)
        {
            var request = new RestRequest(this.ServiceUrl + "/Authenticate", Method.POST);

            request.AddParameter("application/json", SerializeObject(credentials), ParameterType.RequestBody);

            return ExecuteRequest<UserLoggingReason>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/create/{userId}/?provider={provider}")]
        public WcfMembershipUser CreateUser(WcfMembershipUser user, Guid userId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/create/{userId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("userId", userId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(user), ParameterType.RequestBody);

            return ExecuteRequest<WcfMembershipUser>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "{userId}/?provider={provider}")]
        public bool DeleteUser(Guid userId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{userId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("userId", userId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "{userProviderName}/{userName}/{roleId}/?roleProviderName={roleProviderName}")]
        public bool DeleteUserRole(string userProviderName, string userName, Guid roleId, string roleProviderName)
        {
            var request = new RestRequest(this.ServiceUrl + "{userProviderName}/{userName}/{roleId}/?roleProviderName={roleProviderName}", Method.DELETE);

            request.AddUrlSegment("userProviderName", userProviderName);
            request.AddUrlSegment("userName", userName);
            request.AddUrlSegment("roleId", roleId.ToString());
            request.AddUrlSegment("roleProviderName", roleProviderName);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/ForceLogout/?userId={userId}&provider={provider}")]
        public bool ForceLogout(Guid userId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/ForceLogout/?userId={userId}&provider={provider}", Method.GET);

            request.AddUrlSegment("userId", userId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "all/?provider={usersProvider}&forAllProviders={forAllUserProviders}&sort={sort}&take={take}&skip={skip}&filter={filter}&roleProvider={roleProviderName}&roleId={roleIdString}")]
        public WcfMembershipUserCollectionContext GetAllUsers(string usersProvider, bool forAllUserProviders, string sort, string filter, int skip, int take, string roleProviderName, Guid roleId)
        {
            var request = new RestRequest(this.ServiceUrl + "all/?provider={usersProvider}&forAllProviders={forAllUserProviders}&sort={sort}&take={take}&skip={skip}&filter={filter}&roleProvider={roleProviderName}&roleId={roleId}", Method.GET);

            request.AddUrlSegment("usersProvider", usersProvider);
            request.AddUrlSegment("forAllUserProviders", forAllUserProviders.ToString());
            request.AddUrlSegment("sort", sort);
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("roleProviderName", roleProviderName);
            request.AddUrlSegment("roleId", roleId.ToString());

            return ExecuteRequest<WcfMembershipUserCollectionContext>(request);
        }

        //[WebGet(UriTemplate = "/GetLoggedInUsersCount/?provider={provider}")]
        public int GetLoggedInUsersCount(string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/GetLoggedInUsersCount/?provider={provider}", Method.GET);

            request.AddUrlSegment("provider", provider);
            
            return ExecuteRequest<int>(request);
        }

        //[WebGet(UriTemplate = "{userId}/?provider={provider}")]
        public WcfMembershipUser GetUser(Guid userId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "{userId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("userId", userId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<WcfMembershipUser>(request);
        }

        //[WebGet(UriTemplate = "/GetUserProviders/?roleId={roleId}&roleProvider={roleProvider}&userFilter={userFilter}")]
        public CollectionContext<UserProviderItem> GetUserProviders(Guid roleId, string roleProvider, string userFilter)
        {
            var request = new RestRequest(this.ServiceUrl + "/GetUserProviders/?roleId={roleId}&roleProvider={roleProvider}&userFilter={userFilter}", Method.GET);

            request.AddUrlSegment("roleId", roleId.ToString());
            request.AddUrlSegment("roleProvider", roleProvider);
            request.AddUrlSegment("userFilter", userFilter);
            
            return ExecuteRequest<CollectionContext<UserProviderItem>>(request);
        }

        //[WebGet(UriTemplate = "{userProviderName}/{userName}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<RoleProviderPair> GetUserRoles(string userProviderName, string userName, string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "{userProviderName}/{userName}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("userProviderName", userProviderName);
            request.AddUrlSegment("userName", userName);
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<RoleProviderPair>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&roleId={roleId}&roleProvider={roleProvider}&forAllProviders={forAllProviders}")]
        public CollectionContext<WcfMembershipUser> GetUsers(string provider, string sortExpression, int skip, int take, string filter, Guid roleId, string roleProvider, bool forAllProviders)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}&roleId={roleId}&roleProvider={roleProvider}&forAllProviders={forAllProviders}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);
            request.AddUrlSegment("roleId", roleId.ToString());
            request.AddUrlSegment("roleProvider", roleProvider);
            request.AddUrlSegment("forAllProviders", forAllProviders.ToString());

            return ExecuteRequest<CollectionContext<WcfMembershipUser>>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/Logout")]
        public bool Logout()
        {
            var request = new RestRequest(this.ServiceUrl + "/Logout", Method.GET);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/Logout/{providerName}/{userName}")]
        public bool LogoutUser(string providerName, string userName)
        {
            var request = new RestRequest(this.ServiceUrl + "/Logout/{providerName}/{userName}", Method.GET);

            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("userName", userName);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/LogoutCredentials")]
        public bool LogoutWithCredentials(Credentials credentials)
        {
            var request = new RestRequest(this.ServiceUrl + "/LogoutCredentials", Method.POST);

            request.AddParameter("application/json", SerializeObject(credentials), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/SaveUserRole/")]
        public void SaveUserRole(UserRolesItem[] usersRoles)
        {
            var request = new RestRequest(this.ServiceUrl + "/SaveUserRole/", Method.PUT);

            request.AddParameter("application/json", SerializeObject(usersRoles), ParameterType.RequestBody);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/update/{userId}/?provider={provider}")]
        public WcfMembershipUser UpdateUser(WcfMembershipUser user, Guid userId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/update/{userId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("userId", userId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(user), ParameterType.RequestBody);

            return ExecuteRequest<WcfMembershipUser>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/updateBasicInfo/{userId}/?provider={provider}")]
        public WcfMembershipUser UpdateUserBasic(WcfMembershipUser user, Guid userId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/updateBasicInfo/{userId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("userId", userId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(user), ParameterType.RequestBody);

            return ExecuteRequest<WcfMembershipUser>(request);
        }
    }
}
