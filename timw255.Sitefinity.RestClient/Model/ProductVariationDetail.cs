using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProductVariationDetail : IDynamicFieldsContainer
    {
        public string ApplicationName { get; set; }
        public Guid Id { get; set; }
        public Guid ProductVariationDetailParentId { get; set; }

        public ProductVariationDetail() { }
    }
}
