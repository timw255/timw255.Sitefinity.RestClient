using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Exceptions;

namespace timw255.Sitefinity.RestClient
{
    public class SitefinityRestClient : IDisposable
    {
        private RestSharp.RestClient _restClient;
        private string _baseUrl;
        private string _username;
        private string _password;

        public SitefinityRestClient(string username, string password, string baseUrl)
        {
            this._username = username;
            this._password = password;
            this._baseUrl = String.Concat(baseUrl.TrimEnd('/'), "/");

            Uri uriResult;
            Uri.TryCreate(this._baseUrl, UriKind.Absolute, out uriResult);

            this._restClient = new RestSharp.RestClient(uriResult);
            this._restClient.CookieContainer = new CookieContainer();
            this._restClient.ClearHandlers();
            this._restClient.AddHandler("application/json", new JsonDeserializer());

            this.SignIn();
        }

        protected internal IRestResponse ExecuteRequest(IRestRequest request, bool isRetry = false)
        {
            IRestResponse response = _restClient.Execute(request);

            if (response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.Unauthorized)
            {
                if (isRetry)
                {
                    throw new SitefinityException("User already logged in");
                }
                else
                {
                    SelfLogout();
                    ExecuteRequest(request, true);
                }
            }

            return response;
        }

        private void SignIn()
        {
            RestRequest request = new RestRequest("Sitefinity/Authenticate", Method.GET);

            IRestResponse response = _restClient.Execute(request);

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    request = new RestRequest("Sitefinity/Authenticate/SWT?realm={realm}&redirect_uri={redirectUri}&deflate=true", Method.POST);

                    request.AddUrlSegment("realm", _baseUrl);
                    request.AddUrlSegment("redirectUri", "/Sitefinity");

                    request.AddParameter("wrap_name", _username, ParameterType.GetOrPost);
                    request.AddParameter("wrap_password", _password, ParameterType.GetOrPost);
                    request.AddParameter("sf_persistent", "true", ParameterType.GetOrPost);

                    response = _restClient.Execute(request);

                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.OK:
                            if (response.ResponseUri.AbsolutePath == "/Sitefinity/SignOut/selflogout")
                            {
                                SelfLogout();
                            }
                            break;
                        case HttpStatusCode.Unauthorized:
                            throw new SitefinityException("Invalid username or password");
                        default:
                            break;
                    }
                    break;
                case HttpStatusCode.Redirect:
                    throw new NotImplementedException("External STS not supported");
                default:
                    break;
            }
        }

        private void SelfLogout()
        {
            RestRequest request = new RestRequest("Sitefinity/SignOut/selflogout?ReturnUrl=%2fSitefinity%2fdashboard", Method.POST);

            request.AddParameter("__EVENTTARGET", "ctl04$ctl00$ctl00$ctl00$ctl00$ctl00$selfLogoutButton");
            request.AddParameter("__EVENTARGUMENT", "");

            _restClient.Execute(request);

            return;
        }

        private void SignOut()
        {
            RestRequest request = new RestRequest("Sitefinity/SignOut?sts_signout=true", Method.GET);

            ExecuteRequest(request);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~SitefinityRestClient() 
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing) 
            {
                this.SignOut();
            }
        }
    }
}
