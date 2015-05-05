using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SmtpSettingsViewModel
    {
        public string Host { get; set; }
        public string NotificationsSmtpProfile { get; set; }
        public int Port { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpUsername { get; set; }
        public string TestEmailAddress { get; set; }
        public bool UseAuthentication { get; set; }
        public bool UseSmtpSSL { get; set; }

        public SmtpSettingsViewModel() { }
    }
}
