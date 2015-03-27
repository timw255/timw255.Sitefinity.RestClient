using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class OrderSummaryChartViewModel
    {
        [DataMember]
        public int NumberOfOrders { get; set; }

        [DataMember]
        public string StatisticDate { get; set; }

        public OrderSummaryChartViewModel() { }
    }
}
