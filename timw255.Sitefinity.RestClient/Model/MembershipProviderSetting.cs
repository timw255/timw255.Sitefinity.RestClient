using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MembershipProviderSetting
    {
        public bool EnablePasswordReset { get; set; }
        public bool EnablePasswordRetrieval { get; set; }
        public string Name { get; set; }
        public bool RequiresQuestionAndAnswer { get; set; }

        public MembershipProviderSetting() { }
    }
}
