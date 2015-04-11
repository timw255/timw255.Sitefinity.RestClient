using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class OrderSummaryReportGridViewModel
    {
        public string Discounts { get; set; }
        public int NumberOfOrders { get; set; }
        public string Shipping { get; set; }
        public string StatisticDate { get; set; }
        public string SubTotal { get; set; }
        public string Taxes { get; set; }
        public string Total { get; set; }

        public OrderSummaryReportGridViewModel() { }
    }
}
