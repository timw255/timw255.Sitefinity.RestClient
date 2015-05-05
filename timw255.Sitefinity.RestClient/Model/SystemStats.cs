using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SystemStats
    {
        public int ABCampaignCount { get; set; }
        public int CampaignCount { get; set; }
        public int MailingListsCount { get; set; }
        public int MessageTemplatesCount { get; set; }
        public int SubscribersCount { get; set; }

        public SystemStats() { }
    }
}
