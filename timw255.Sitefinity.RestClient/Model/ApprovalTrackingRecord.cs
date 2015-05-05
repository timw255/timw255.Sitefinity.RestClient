using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ApprovalTrackingRecord
    {
        public int Culture { get; set; }
        public DateTime DateCreated { get; set; }
        public string Note { get; set; }
        [Obsolete("This field is no longer used. As of 7.0 Sitefinity does not have a mapping for ApprovalTrackingRecordMap")]
        public IList<ApprovalTrackingRecordMap> Parents { get; set; }
        public string Status { get; set; }
        public Guid UserId { get; set; }
        public Guid WorkflowItemId { get; set; }

        public ApprovalTrackingRecord() { }
    }
}
