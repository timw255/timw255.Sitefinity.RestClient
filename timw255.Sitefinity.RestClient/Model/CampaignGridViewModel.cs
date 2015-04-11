using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CampaignGridViewModel
    {
        public string CampaignReportUrl { get; set; }
        public CampaignState CampaignState { get; set; }
        public string CampaignStateClass { get; set; }
        public string CampaignStateUX { get; set; }
        public string CampaignTypeUX { get; set; }
        [Obsolete("You can only create issues from the grid.")]
        public string GridActionMode { get; set; }
        public Guid Id { get; set; }
        [Obsolete("The grid does not care about the latest A/B test.")]
        public Guid LatestAbTestId { get; set; }
        [Obsolete("The grid does not care about the latest issue.")]
        public Guid LatestIssueId { get; set; }
        [Obsolete("The grid does not care about the latest issue.")]
        public Guid LatestIssueMessageBodyId { get; set; }
        public int ListSubscriberCount { get; set; }
        public Guid MessageBodyId { get; set; }
        public MessageBodyType MessageBodyType { get; set; }
        public string Name { get; set; }

        public CampaignGridViewModel() { }
    }
}
