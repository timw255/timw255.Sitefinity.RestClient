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
        public Lstring ApprovalWorkflowState { get; set; }
        public Lstring Author { get; set; }
        public Lstring Content { get; set; }
        public Lstring ItemDefaultUrl { get; set; }
        public string SourceName { get; set; }
        public string SourceSite { get; set; }
        public Lstring Summary { get; set; }

        public NewsItem() { }
    }
}
