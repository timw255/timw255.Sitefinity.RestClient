using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SummaryItemTypeDetails
    {
        public string ErrorDetails { get; set; }
        public int FailedItemsCount { get; set; }
        public string FriendlyTypeName { get; set; }
        public string SuccessDetails { get; set; }
        public int SuccessfulItemsCount { get; set; }
        public int TotalCount { get; set; }
        public string Type { get; set; }

        public SummaryItemTypeDetails() { }
    }
}
