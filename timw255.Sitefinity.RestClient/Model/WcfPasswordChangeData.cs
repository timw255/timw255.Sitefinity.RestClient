using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPasswordChangeData : WcfItemBase
    {
        public string NewPassword { get; set; }
        public string OldPassword { get; set; }

        public WcfPasswordChangeData() { }
    }
}
