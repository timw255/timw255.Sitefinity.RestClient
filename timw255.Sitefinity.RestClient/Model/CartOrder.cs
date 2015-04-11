using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CartOrder : IDynamicFieldsContainer
    {
        public IList<CartAddress> Addresses { get; set; }
        public string ApplicationName { get; set; }
        public IList<CouponCode> CouponCodes { get; set; }
        public string Currency { get; set; }
        public IList<CartDetail> Details { get; set; }
        public IList<CartDiscount> Discounts { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal ExchangeRateDiscountTotal { get; set; }
        public decimal ExchangeRatePreTaxTotal { get; set; }
        public decimal ExchangeRateSubTotal { get; set; }
        public decimal ExchangeRateSubTotalDisplay { get; set; }
        public decimal ExchangeRateTax { get; set; }
        public decimal ExchangeRateTotal { get; set; }
        public Guid Id { get; set; }
        public bool IsShippable { get; set; }
        public DateTime LastModified { get; set; }
        public int OrderAttempts { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public IList<CartPayment> Payments { get; set; }
        public decimal PreTaxTotal { get; set; }
        public string ShippingCarrierName { get; set; }
        public Guid? ShippingMethodId { get; set; }
        public string ShippingServiceCode { get; set; }
        public string ShippingServiceName { get; set; }
        public decimal SubTotalDisplay { get; set; }
        public decimal Total { get; set; }
        public Guid? UserId { get; set; }
        public double Weight { get; set; }

        public CartOrder() { }
    }
}
