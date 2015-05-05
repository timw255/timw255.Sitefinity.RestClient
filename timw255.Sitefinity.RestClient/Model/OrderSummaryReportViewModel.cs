using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class OrderSummaryReportViewModel
    {
        public List<OrderSummaryChartViewModel> ChartData { get; set; }
        public IEnumerable<OrderSummaryReportGridViewModel> GridData { get; set; }
        public OrderSummaryHighlightViewModel HighlightData { get; set; }

        public OrderSummaryReportViewModel() { }
    }
}
