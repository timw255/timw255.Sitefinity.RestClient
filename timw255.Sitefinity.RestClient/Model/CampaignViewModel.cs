using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CampaignViewModel
    {
        public string CampaignReportUrl { get; set; }
        public CampaignState CampaignState { get; set; }
        public string CampaignStateClass { get; set; }
        public string CampaignStateUX { get; set; }
        public Guid CampaignTemplateId { get; set; }
        public string CampaignTypeUX { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string FromName { get; set; }
        public Guid Id { get; set; }
        public bool IsReadyForSending { get; set; }
        public Guid ListId { get; set; }
        public int ListSubscriberCount { get; set; }
        public string ListTitle { get; set; }
        public IList<MergeTagViewModel> MergeTags { get; set; }
        public MessageBodyViewModel MessageBody { get; set; }
        public string MessageSubject { get; set; }
        public string Name { get; set; }
        public string ReplyToEmail { get; set; }
        public bool UseGoogleTracking { get; set; }

        public CampaignViewModel() { }
    }
}
