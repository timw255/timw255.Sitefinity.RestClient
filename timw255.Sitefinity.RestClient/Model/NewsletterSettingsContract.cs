using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class NewslettersSettingsContract
    {
        public BounceAction MailboxFullBounceAction { get; set; }
        public string NotificationsSmtpProfile { get; set; }
        public BounceAction NoUserBounceAction { get; set; }
        public string Pop3Password { get; set; }
        public int Pop3Port { get; set; }
        public string Pop3Server { get; set; }
        public string Pop3Username { get; set; }
        public bool Pop3UsesSSL { get; set; }
        public string SmtpHost { get; set; }
        public string SmtpPassword { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public bool TrackBouncedMessages { get; set; }
        public BounceAction UnknownBounceAction { get; set; }
        public bool UseSmtpAuthentication { get; set; }
        public bool UseSmtpSSL { get; set; }

        public NewslettersSettingsContract() { }
    }
}
