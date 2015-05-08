using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce.Catalog
{
    public class ProductVariationDetailServiceWrapper : ServiceWrapper
    {
        public ProductVariationDetailServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Catalog/ProductVariationDetail.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}")]
        public bool BatchDeleteProductVariationDetails(Guid[] attributeIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(attributeIds), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{attributeId}/?provider={provider}")]
        public bool DeleteProductVariationDetail(Guid attributeId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{attributeId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("attributeId", attributeId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebGet(UriTemplate = "/{attributeId}/?provider={provider}")]
        public ItemContext<ProductVariationDetail> GetProductVariationDetail(Guid attributeId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{attributeId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("attributeId", attributeId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<ItemContext<ProductVariationDetail>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ProductVariationDetail> GetProductVariationDetails(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<ProductVariationDetail>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{attributeId}/?provider={provider}")]
        public ItemContext<ProductVariationDetail> SaveProductVariationDetail(Guid attributeId, ItemContext<ProductVariationDetail> attribute, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{attributeId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("attributeId", attributeId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(attribute), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<ProductVariationDetail>>(request);
        }
    }
}
