using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class OrderDetail : IDynamicFieldsContainer
    {
        public string ApplicationName { get; set; }
        public decimal BasePrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal DeltaPrice { get; set; }
        public string Description { get; set; }
        public string DisplayPriceFormatted { get; set; }
        public string DisplayTotalFormatted { get; set; }
        public decimal ExchangeRateBasePrice { get; set; }
        public decimal ExchangeRateBasePriceIncludingTax { get; set; }
        public decimal ExchangeRatePrice { get; set; }
        public decimal ExchangeRatePriceIncludingTax { get; set; }
        public Guid Id { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsShippable { get; set; }
        public DateTime LastModified { get; set; }
        public string Options { get; set; }
        public decimal Price { get; set; }
        public string PriceFormatted { get; set; }
        public bool ProductAvailable { get; set; }
        public Guid ProductId { get; set; }
        public ProductImage ProductImage { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
        public Guid TaxClassId { get; set; }
        public bool TaxInPrice { get; set; }
        public decimal TaxRate { get; set; }
        public string Title { get; set; }
        public decimal Total { get; set; }
        public string TotalFormatted { get; set; }
        public string VariantAsIds { get; set; }
        public string VariantAsNames { get; set; }
        public double Weight { get; set; }
        public Guid? WishlistDetailId { get; set; }

        public OrderDetail() { }
    }
}
