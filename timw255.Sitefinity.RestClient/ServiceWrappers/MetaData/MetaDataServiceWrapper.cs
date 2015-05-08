using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.MetaData
{
    public class MetaDataServiceWrapper : ServiceWrapper
    {
        public MetaDataServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/MetaData/MetaData.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "{fieldId}/?typeId={typeId}")]
        public bool DeleteField(Guid fieldId, Guid typeId)
        {
            var request = new RestRequest(this.ServiceUrl + "{fieldId}/?typeId={typeId}", Method.DELETE);

            request.AddUrlSegment("fieldId", fieldId.ToString());
            request.AddUrlSegment("typeId", typeId.ToString());

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "{fieldId}/?typeId={typeId}")]
        public FieldType GetField(Guid fieldId, Guid typeId)
        {
            var request = new RestRequest(this.ServiceUrl + "{fieldId}/?typeId={typeId}", Method.GET);

            request.AddUrlSegment("fieldId", fieldId.ToString());
            request.AddUrlSegment("typeId", typeId.ToString());

            return ExecuteRequest<FieldType>(request);
        }

        //[WebGet(UriTemplate = "/?typeId={typeId}")]
        public CollectionContext<FieldType> GetFields(Guid typeId)
        {
            var request = new RestRequest(this.ServiceUrl + "/?typeId={typeId}", Method.GET);

            request.AddUrlSegment("typeId", typeId.ToString());

            return ExecuteRequest<CollectionContext<FieldType>>(request);
        }
    }
}
