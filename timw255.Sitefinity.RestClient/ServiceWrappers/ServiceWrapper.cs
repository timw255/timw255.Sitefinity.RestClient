using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.SitefinityClient.Exceptions;

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

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new InvalidRequestException(response.StatusDescription);
            }

            return;
        }

        public T ExecuteRequestFor<T>(IRestRequest r)
        {
            IRestResponse response = _sf.ExecuteRequest(r);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                T result = DeserializeResponseAs<T>(response.Content);
                return result;
            }
            else
            {
                throw new InvalidRequestException(response.StatusDescription);
            }
        }

        public static T DeserializeResponseAs<T>(string j)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));

            using (MemoryStream m = new MemoryStream(System.Text.ASCIIEncoding.ASCII.GetBytes(j)))
            {
                T result = (T)serializer.ReadObject(m);
                return result;
            }
        }

        public static string SerializeObject<T>(T o)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));

            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, o);
                string j = Encoding.Default.GetString(ms.ToArray());
                return j;
            }
        }
    }
}
