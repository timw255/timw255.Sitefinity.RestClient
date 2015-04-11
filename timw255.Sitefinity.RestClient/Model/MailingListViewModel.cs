using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MailingListViewModel
    {
        public string ApplicationName { get; set; }
        public int CampaignsCount { get; set; }
        public string CampaignsText { get; set; }
        public string DefaultFromName { get; set; }
        public string DefaultReplyToEmail { get; set; }
        public string DefaultSubject { get; set; }
        public IList<DynamicListSettingsViewModel> DynamicLists { get; set; }
        public string GoodByeMessageEmailAddress { get; set; }
        public string GoodByeMessageSubject { get; set; }
        public Guid GoodByeTemplateId { get; set; }
        public Guid Id { get; set; }
        public bool SendGoodByeMessage { get; set; }
        public bool SendWelcomeMessage { get; set; }
        public string SubscribersCount { get; set; }
        public string SubscribersCountText { get; set; }
        public string SubscriptionReminder { get; set; }
        public string Title { get; set; }
        public Guid UnsubscribePageId { get; set; }
        public string WelcomeMessageEmailAddress { get; set; }
        public string WelcomeMessageSubject { get; set; }
        public Guid WelcomeTemplateId { get; set; }

        public MailingListViewModel() { }
    }
}
