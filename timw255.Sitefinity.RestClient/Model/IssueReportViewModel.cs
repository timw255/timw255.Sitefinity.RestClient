using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [Obsolete("Use IssueGridViewModel instead.")]
    public class IssueReportViewModel
    {
        public string CampaignName { get; set; }
        public int SuccessfulDeliveries { get; set; }
        public int TotalClicks { get; set; }
        public int TotalTimesOpened { get; set; }

        public IssueReportViewModel() { }
    }
}
