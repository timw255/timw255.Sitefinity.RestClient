using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce.Catalog
{
    public class ProductVariationServiceWrapper : ServiceWrapper
    {
        public ProductVariationServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Catalog/ProductVariation.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}")]
        public bool BatchDeleteProductVariations(Guid[] productVariationIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(productVariationIds), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/parent/{parentId}/batch/?provider={provider}")]
        public bool BatchDeleteProductVariationsWithParent(Guid parentId, Guid[] productVariationIds, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/batch/?provider={provider}", Method.POST);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(productVariationIds), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{productVariationId}/?provider={provider}")]
        public bool DeleteProductVariation(Guid productVariationId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{productVariationId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("productVariationId", productVariationId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/parent/{parentId}/{productVariationId}/?provider={provider}")]
        public bool DeleteProductVariationWithParent(Guid parentId, Guid productVariationId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/{productVariationId}/?provider={provider}", Method.DELETE);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("productVariationId", productVariationId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "GET", UriTemplate = "/attributevalues/{productId}/?provider={provider}")]
        public CollectionContext<ProductAttributeValuePairViewModel> GetAttributeValues(Guid productId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/attributevalues/{productId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("productId", productId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<CollectionContext<ProductAttributeValuePairViewModel>>(request);
        }

        //[WebGet(UriTemplate = "/parent/{parentId}/{productVariationId}/?provider={provider}")]
        public ItemContext<ProductVariation> GetChildProductVariation(Guid parentId, Guid productVariationId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/{productVariationId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("productVariationId", productVariationId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<ItemContext<ProductVariation>>(request);
        }

        //[WebGet(UriTemplate = "/{productVariationId}/?provider={provider}")]
        public ItemContext<ProductVariation> GetProductVariation(Guid productVariationId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{productVariationId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("productVariationId", productVariationId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequest<ItemContext<ProductVariation>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ProductVariation> GetProductVariations(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<ProductVariation>>(request);
        }

        //[WebGet(UriTemplate = "/parent/{parentId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ProductVariation> GetProductVariationsOfParent(Guid parentId, string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequest<CollectionContext<ProductVariation>>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/makeactive/?provider={provider}")]
        public bool MakeActive(Guid productVariationId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/makeactive/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(productVariationId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/makeinactive/?provider={provider}")]
        public bool MakeInActive(Guid productVariationId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/makeinactive/?provider={provider}", Method.POST);

            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(productVariationId), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{productVariationId}/?provider={provider}")]
        public ItemContext<ProductVariation> SaveProductVariation(Guid productVariationId, ItemContext<ProductVariation> productVariation, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{productVariationId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("productVariationId", productVariationId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(productVariation), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<ProductVariation>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/parent/{parentId}/?provider={provider}")]
        public bool SaveProductVariationsWithParent(Guid parentId, ProductAttributeViewModel[] attributes, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(attributes), ParameterType.RequestBody);

            return ExecuteRequest<bool>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/parent/{parentId}/{productVariationId}/?provider={provider}")]
        public ItemContext<ProductVariation> SaveProductVariationWithParent(Guid parentId, Guid productVariationId, string serializedProductVariation, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/parent/{parentId}/{productVariationId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("parentId", parentId.ToString());
            request.AddUrlSegment("productVariationId", productVariationId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(serializedProductVariation), ParameterType.RequestBody);

            return ExecuteRequest<ItemContext<ProductVariation>>(request);
        }
    }
}
