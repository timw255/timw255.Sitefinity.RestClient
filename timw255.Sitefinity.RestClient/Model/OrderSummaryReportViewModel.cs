using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class OrderSummaryReportViewModel
    {
        [DataMember]
        public List<OrderSummaryChartViewModel> ChartData { get; set; }

        [DataMember]
        public IEnumerable<OrderSummaryReportGridViewModel> GridData { get; set; }

        [DataMember]
        public OrderSummaryHighlightViewModel HighlightData { get; set; }

        public OrderSummaryReportViewModel() { }
    }
}
