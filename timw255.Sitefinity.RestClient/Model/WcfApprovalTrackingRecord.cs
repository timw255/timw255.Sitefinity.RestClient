using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfApprovalTrackingRecord
    {
        public DateTime DateCreated { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string UIStatus { get; set; }
        public string UserName { get; set; }

        public WcfApprovalTrackingRecord() { }
    }
}
