using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class LifecycleInfo
    {
        public string ErrorMessage { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsLocked { get; set; }
        public bool IsLockedByMe { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
        public string LockedByUsername { get; set; }
        public DateTime? LockedSince { get; set; }
        public string Message { get; set; }
        public DateTime? PublicationDate { get; set; }
        public bool SupportsContentLifecycle { get; set; }
        public string WorkflowStatus { get; set; }

        public LifecycleInfo() { }
    }
}
