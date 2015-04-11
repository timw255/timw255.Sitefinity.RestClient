using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfScheduledTask
    {
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ProgressStatus { get; set; }
        public TaskStatus Status { get; set; }
        public string StatusMessage { get; set; }
        public string TaskName { get; set; }

        public WcfScheduledTask() { }
    }
}
