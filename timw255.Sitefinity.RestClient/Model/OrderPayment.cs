using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class OrderPayment : IDynamicFieldsContainer
    {
        public string ApplicationName { get; set; }
        public string CreditCardNumberLastFour { get; set; }
        public string CreditCardNumberPreview { get; set; }
        public CreditCardType CreditCardType { get; set; }
        public string CreditCardTypeName { get; set; }
        public string GatewayTransactionId { get; set; }
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        public string PaymentMethodFormatted { get; set; }
        public PaymentMethodType PaymentMethodType { get; set; }
        public bool SuccessfulPayment { get; set; }

        public OrderPayment() { }
    }
}
