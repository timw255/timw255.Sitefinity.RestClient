using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;
using timw255.Sitefinity.RestClient.SitefinityClient.ServiceWrappers;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Ecommerce.Catalog
{
    public class ProductTypeServiceWrapper : ServiceWrapper
    {
        public ProductTypeServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Ecommerce/Catalog/ProductTypeService.svc/";
            this.SF = sf;
        }

        //[WebInvoke(Method = "POST", UriTemplate = "/batch/?provider={provider}&language={deletedLanguage}")]
        public bool BatchDeleteProductTypes(Guid[] productTypeIds, string provider, string deletedLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/batch/?provider={provider}&language={deletedLanguage}", Method.POST);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);

            request.AddParameter("application/json", SerializeObject(productTypeIds), ParameterType.RequestBody);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebInvoke(Method = "DELETE", UriTemplate = "/{productTypeId}/?provider={provider}&language={deletedLanguage}")]
        public bool DeleteProductType(Guid productTypeId, string provider, string deletedLanguage)
        {
            var request = new RestRequest(this.ServiceUrl + "/{productTypeId}/?provider={provider}&language={deletedLanguage}", Method.DELETE);

            request.AddUrlSegment("productTypeId", productTypeId.ToString());
            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("deletedLanguage", deletedLanguage);

            return ExecuteRequestFor<bool>(request);
        }

        //[WebGet(UriTemplate = "/{productTypeId}/?provider={provider}")]
        public ItemContext<ProductType> GetProductType(Guid productTypeId, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{productTypeId}/?provider={provider}", Method.GET);

            request.AddUrlSegment("productTypeId", productTypeId.ToString());
            request.AddUrlSegment("provider", provider);

            return ExecuteRequestFor<ItemContext<ProductType>>(request);
        }

        //[WebGet(UriTemplate = "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}")]
        public CollectionContext<ProductTypeViewModel> GetProductTypes(string provider, string sortExpression, int skip, int take, string filter)
        {
            var request = new RestRequest(this.ServiceUrl + "/?provider={provider}&sortExpression={sortExpression}&skip={skip}&take={take}&filter={filter}", Method.GET);

            request.AddUrlSegment("provider", provider);
            request.AddUrlSegment("sortExpression", sortExpression);
            request.AddUrlSegment("skip", skip.ToString());
            request.AddUrlSegment("take", take.ToString());
            request.AddUrlSegment("filter", filter);

            return ExecuteRequestFor<CollectionContext<ProductTypeViewModel>>(request);
        }

        //[WebInvoke(Method = "PUT", UriTemplate = "/{productTypeId}/?provider={provider}")]
        public ItemContext<ProductType> SaveProductType(Guid productTypeId, ItemContext<ProductType> productType, string provider)
        {
            var request = new RestRequest(this.ServiceUrl + "/{productTypeId}/?provider={provider}", Method.PUT);

            request.AddUrlSegment("productTypeId", productTypeId.ToString());
            request.AddUrlSegment("provider", provider);

            request.AddParameter("application/json", SerializeObject(productType), ParameterType.RequestBody);

            return ExecuteRequestFor<ItemContext<ProductType>>(request);
        }
    }
}
