using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Common
{
    public class CommentsServiceWrapper : ServiceWrapper
    {
        public CommentsServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Common/Comments.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/blockemail/{email}/?provider={providerName}&managerType={managerType}")]
        public void BlockCommentsForEmail(string email, string providerName, string managerType)
        {
            var request = new RestRequest(this.ServiceUrl + "/blockemail/{email}/?provider={providerName}&managerType={managerType}", Method.PUT);

            request.AddUrlSegment("email", email);
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("managerType", managerType);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/blockip/{ip}/?provider={providerName}&managerType={managerType}")]
        public void BlockCommentsForIp(string ip, string providerName, string managerType)
        {
            var request = new RestRequest(this.ServiceUrl + "/blockip/{ip}/?provider={providerName}&managerType={managerType}", Method.PUT);

            request.AddUrlSegment("ip", ip);
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("managerType", managerType);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/hide/{commentId}/?provider={providerName}&managerType={managerType}")]
        public void HideComment(Guid commentId, string providerName, string managerType)
        {
            var request = new RestRequest(this.ServiceUrl + "/hide/{commentId}/?provider={providerName}&managerType={managerType}", Method.PUT);

            request.AddUrlSegment("commentId", commentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("managerType", managerType);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/spam/{commentId}/?provider={providerName}&managerType={managerType}")]
        public void MarkCommentAsSpam(Guid commentId, string providerName, string managerType)
        {
            var request = new RestRequest(this.ServiceUrl + "/spam/{commentId}/?provider={providerName}&managerType={managerType}", Method.PUT);

            request.AddUrlSegment("commentId", commentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("managerType", managerType);

            ExecuteRequest(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/publish/{commentId}/?provider={providerName}&managerType={managerType}")]
        public void PublishComment(Guid commentId, string providerName, string managerType)
        {
            var request = new RestRequest(this.ServiceUrl + "/publish/{commentId}/?provider={providerName}&managerType={managerType}", Method.PUT);

            request.AddUrlSegment("commentId", commentId.ToString());
            request.AddUrlSegment("providerName", providerName);
            request.AddUrlSegment("managerType", managerType);

            ExecuteRequest(request);
        }
    }
}
