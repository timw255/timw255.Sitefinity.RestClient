using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CartDetail : IDynamicFieldsContainer
    {
        public string ApplicationName { get; set; }
        public decimal BasePrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal DeltaPrice { get; set; }
        public string Description { get; set; }
        public string DisplayPriceString { get; set; }
        public Guid Id { get; set; }
        public int InventoryAmount { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsShippable { get; set; }
        public DateTime LastModified { get; set; }
        public string Options { get; set; }
        public int PreviousQuantity { get; set; }
        public decimal Price { get; set; }
        public string PriceString { get; set; }
        public bool ProductAvailable { get; set; }
        public Guid ProductId { get; set; }
        public string ProductUrl { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
        public Guid TaxClassId { get; set; }
        public bool TaxInPrice { get; set; }
        public decimal TaxRate { get; set; }
        [Obsolete("Use the Thumbnail extension method in the CartDetailExtensions class")]
        public ProductImage Thumbnail { get; set; }
        public Lstring Title { get; set; }
        public decimal Total { get; set; }
        public string VariantAsIds { get; set; }
        public string VariantAsNames { get; set; }
        [Obsolete]
        public Guid VatTaxId { get; set; }
        public double Weight { get; set; }
        public Guid? WishlistDetailId { get; set; }

        public CartDetail() { }
    }
}
