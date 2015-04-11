using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class TopSellingReportViewModel
    {
        public decimal AveragePrice { get; set; }
        public string AveragePriceFormatted { get; set; }
        public string ProductTypeTitle { get; set; }
        public int QuantitySold { get; set; }
        public string Sku { get; set; }
        public string Title { get; set; }
        public decimal Total { get; set; }
        public string TotalFormatted { get; set; }

        public TopSellingReportViewModel() { }
    }
}
