using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class IssueGridViewModel
    {
        public int Clicked { get; set; }
        public DateTime? DateSent { get; set; }
        public int Delivered { get; set; }
        public Guid Id { get; set; }
        public string IssueReportUrl { get; set; }
        public string IssueStateClass { get; set; }
        public string IssueStateUX { get; set; }
        public DateTime LastModified { get; set; }
        public Guid MessageBodyId { get; set; }
        public MessageBodyType MessageBodyType { get; set; }
        public string Name { get; set; }
        public int Opened { get; set; }
        public Guid RootCampaignId { get; set; }
        public int Sent { get; set; }

        public IssueGridViewModel() { }
    }
}
