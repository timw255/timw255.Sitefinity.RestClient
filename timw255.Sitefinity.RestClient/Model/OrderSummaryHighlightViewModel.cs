using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class OrderSummaryHighlightViewModel
    {
        public string TotalDiscounts { get; set; }
        public int TotalOrders { get; set; }
        public string TotalSales { get; set; }
        public string TotalShipping { get; set; }
        public string TotalSubTotal { get; set; }
        public string TotalTaxes { get; set; }

        public OrderSummaryHighlightViewModel() { }
    }
}
