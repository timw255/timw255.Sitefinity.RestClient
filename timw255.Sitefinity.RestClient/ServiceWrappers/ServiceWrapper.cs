using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers
{
    public abstract class ServiceWrapper
    {
        private SitefinityRestClient _sf;

        public SitefinityRestClient SF
        {
            get
            {
                return this._sf;
            }
            set
            {
                this._sf = value;
            }
        }

        private string _serviceUrl;

        public string ServiceUrl
        {
            get
            {
                return this._serviceUrl;
            }
            set
            {
                this._serviceUrl = value;
            }
        }

        public void ExecuteRequest(IRestRequest r)
        {
            IRestResponse response = _sf.ExecuteRequest(r);
            return;
        }

        public T ExecuteRequest<T>(IRestRequest r)
        {
            IRestResponse response = _sf.ExecuteRequest(r);

            T result = DeserializeResponseAs<T>(response.Content);
            return result;
        }

        public static T DeserializeResponseAs<T>(string j)
        {
            var jsonSettings = new JsonSerializerSettings();

            // uncomment if you want a heads up when there are members missing from the model classes.
            //jsonSettings.MissingMemberHandling = MissingMemberHandling.Error;
            
            T result = JsonConvert.DeserializeObject<T>(j, jsonSettings);
            return result;
        }

        public static string SerializeObject<T>(T o)
        {
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };

            string j = JsonConvert.SerializeObject(o, serializerSettings);
            return j;
        }
    }
}
