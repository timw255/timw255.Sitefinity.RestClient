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
    public class TopSellingReportViewModel : IDataItem
    {
        public string ApplicationName { get; set; }

        [DataMember]
        public decimal AveragePrice { get; set; }

        [DataMember]
        public string AveragePriceFormatted { get; set; }

        public Guid Id { get; set; }

        public DateTime LastModified { get; set; }

        [DataMember]
        public string ProductTypeTitle { get; set; }

        public object Provider { get; set; }

        [DataMember]
        public int QuantitySold { get; set; }

        [DataMember]
        public string Sku { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public decimal Total { get; set; }

        [DataMember]
        public string TotalFormatted { get; set; }

        public object Transaction { get; set; }

        public string VariantsAsIds { get; set; }

        public TopSellingReportViewModel() { }
    }
}
