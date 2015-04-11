using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProductAttributeValuePairViewModel
    {
        public ProductAttribute Attribute { get; set; }
        public List<ProductAttributeValue> AttributeValues { get; set; }

        public ProductAttributeValuePairViewModel() { }
    }
}
