using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProductAttributeViewModel
    {
        public string AttributeId { get; set; }
        public List<string> AttributeValueIds { get; set; }
        public List<string> AttributeValueNames { get; set; }

        public ProductAttributeViewModel() { }
    }
}
