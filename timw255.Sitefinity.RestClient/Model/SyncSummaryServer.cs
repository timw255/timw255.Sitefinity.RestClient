using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.SiteSync;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class SyncSummaryServer
    {
        [DataMember]
        public int FailedItems { get; set; }

        [DataMember]
        public string ServerId { get; set; }

        [DataMember]
        public string ServerName { get; set; }

        [DataMember]
        public IList<SummaryItemSiteDetails> SummaryItemDetails { get; set; }

        [DataMember]
        public int SyncedItems { get; set; }

        [DataMember]
        public int TotalItems { get; set; }

        public SyncSummaryServer() { }
    }
}
