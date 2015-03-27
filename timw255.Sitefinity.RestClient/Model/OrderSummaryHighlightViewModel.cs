using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class OrderSummaryHighlightViewModel
    {
        [DataMember]
        public string TotalDiscounts { get; set; }

        [DataMember]
        public int TotalOrders { get; set; }

        [DataMember]
        public string TotalSales { get; set; }

        [DataMember]
        public string TotalShipping { get; set; }

        [DataMember]
        public string TotalSubTotal { get; set; }

        [DataMember]
        public string TotalTaxes { get; set; }

        public OrderSummaryHighlightViewModel() { }
    }
}
