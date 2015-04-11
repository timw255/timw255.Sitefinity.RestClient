using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class NewsItem : ContentBase
    {
        public LstringSingleViewModel ApprovalWorkflowState { get; set; }
        public LstringSingleViewModel Author { get; set; }
        public LstringSingleViewModel Content { get; set; }
        public LstringSingleViewModel ItemDefaultUrl { get; set; }
        public string SourceName { get; set; }
        public string SourceSite { get; set; }
        public LstringSingleViewModel Summary { get; set; }

        public NewsItem() { }
    }
}
