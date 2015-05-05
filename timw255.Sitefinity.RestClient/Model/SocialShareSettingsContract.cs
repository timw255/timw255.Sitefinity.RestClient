using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SocialShareSettingsContract : ConfigSettingsContractBase
    {
        public bool Blogger { get; set; }
        public bool Delicious { get; set; }
        public bool Digg { get; set; }
        public bool DisplayCounters { get; set; }
        public bool Facebook { get; set; }
        public bool GoogleBookmarks { get; set; }
        public bool GooglePlusOne { get; set; }
        public bool LinkedIn { get; set; }
        public bool MailTo { get; set; }
        public bool MySpace { get; set; }
        public bool Reddit { get; set; }
        public SocialShareMode SocialShareMode { get; set; }
        public bool StumbleUpon { get; set; }
        public bool Tumblr { get; set; }
        public bool Twitter { get; set; }

        public SocialShareSettingsContract() { }
    }
}
