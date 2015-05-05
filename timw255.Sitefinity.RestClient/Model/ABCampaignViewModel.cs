using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ABCampaignViewModel
    {
        public string ABCampaignReportUrl { get; set; }
        public string CampaignAFromName { get; set; }
        public Guid CampaignAId { get; set; }
        public string CampaignAList { get; set; }
        public MessageBodyType CampaignAMessageBodyType { get; set; }
        public string CampaignAMessageSubject { get; set; }
        public string CampaignAName { get; set; }
        public string CampaignAReplyToEmail { get; set; }
        public string CampaignBFromName { get; set; }
        public Guid CampaignBId { get; set; }
        public string CampaignBList { get; set; }
        public MessageBodyType CampaignBMessageBodyType { get; set; }
        public string CampaignBMessageSubject { get; set; }
        public string CampaignBName { get; set; }
        public string CampaignBReplyToEmail { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid RootCampaignId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public string SubscribersCount { get; set; }
        public DateTime TestingEnds { get; set; }
        public string TestingEndsUX { get; set; }
        public string TestingNote { get; set; }
        public decimal TestingSamplePercentage { get; set; }
        public int WinningCondition { get; set; }
        public string WinningConditionUX { get; set; }

        public ABCampaignViewModel() { }
    }
}
