using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Model;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class OrderSummaryReportGridViewModel : IDataItem
    {
        public string ApplicationName { get; set; }

        [DataMember]
        public string Discounts { get; set; }

        public Guid Id { get; set; }

        public DateTime LastModified { get; set; }

        [DataMember]
        public int NumberOfOrders { get; set; }

        public object Provider { get; set; }

        [DataMember]
        public string Shipping { get; set; }

        [DataMember]
        public string StatisticDate { get; set; }

        [DataMember]
        public string SubTotal { get; set; }

        [DataMember]
        public string Taxes { get; set; }

        [DataMember]
        public string Total { get; set; }

        public object Transaction { get; set; }

        public OrderSummaryReportGridViewModel() { }
    }
}
