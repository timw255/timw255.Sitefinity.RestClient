using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProductVariation : IDynamicFieldsContainer
    {
        public decimal AdditionalPrice { get; set; }
        public string DeltaPriceDisplay { get; set; }
        public Guid Id { get; set; }
        public List<ProductImage> Images { get; set; }
        public string InventoryDisplay { get; set; }
        public string InventoryJson { get; set; }
        public bool IsActive { get; set; }
        public string Sku { get; set; }
        public ProductImage Thumbnail { get; set; }
        public string Variant { get; set; }
        public AttributeValueNamePair VariantNames { get; set; }

        public ProductVariation() { }
    }
}
