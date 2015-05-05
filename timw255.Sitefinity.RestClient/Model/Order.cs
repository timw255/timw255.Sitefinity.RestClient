using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Order : IDynamicFieldsContainer
    {
        public IList<OrderAddress> Addresses { get; set; }
        public string Currency { get; set; }
        public decimal CurrencyExchangeRate { get; set; }
        public string CurrencyInfo { get; set; }
        public CurrencyRounding CurrencyRounding { get; set; }
        public string CustomerName { get; set; }
        public CustomerSummary CustomerSummary { get; set; }
        public string DefaultCurrency { get; set; }
        public string DefaultCurrencyInfo { get; set; }
        public IList<OrderDetail> Details { get; set; }
        public IList<OrderDiscount> Discounts { get; set; }
        public decimal DiscountTotal { get; set; }
        public string DiscountTotalFormatted { get; set; }
        public decimal EffectiveTaxRate { get; set; }
        public decimal ExchangeRateDiscountTotal { get; set; }
        public decimal ExchangeRatePreTaxTotal { get; set; }
        public decimal ExchangeRateShippingTotal { get; set; }
        public decimal ExchangeRateSubTotal { get; set; }
        public decimal ExchangeRateSubTotalDisplay { get; set; }
        public decimal ExchangeRateTax { get; set; }
        public decimal ExchangeRateTotal { get; set; }
        public Guid Id { get; set; }
        public bool IsShippable { get; set; }
        public int OrderAttempts { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public IList<OrderStatusHistory> OrderStatusHistory { get; set; }
        public string OrderStatusTitle { get; set; }
        public IList<OrderPayment> Payments { get; set; }
        public decimal PreDiscountTax { get; set; }
        public decimal PreTaxPrice { get; set; }
        public string PreTaxPriceFormatted { get; set; }
        public decimal PreTaxTotal { get; set; }
        public string PreTaxTotalFormatted { get; set; }
        public UserProfile Profile { get; set; }
        public DateTime? ShippedOn { get; set; }
        public string ShippedOnString { get; set; }
        public string ShippingCarrierName { get; set; }
        public Guid? ShippingMethodId { get; set; }
        public string ShippingServiceName { get; set; }
        public decimal ShippingTotal { get; set; }
        public string ShippingTotalFormatted { get; set; }
        public bool ShowShippedOn { get; set; }
        public decimal SubTotalDisplay { get; set; }
        public string SubTotalFormatted { get; set; }
        public decimal Tax { get; set; }
        public string TaxFormatted { get; set; }
        public bool TaxInPrice { get; set; }
        public decimal Total { get; set; }
        public string TotalFormatted { get; set; }
        public int TotalItemsInOrder { get; set; }
        public string TrackingNumber { get; set; }
        public double Weight { get; set; }

        public Order() { }
    }
}
