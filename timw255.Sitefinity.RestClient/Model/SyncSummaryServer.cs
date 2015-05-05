using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SyncSummaryServer
    {
        public int FailedItems { get; set; }
        public string ServerId { get; set; }
        public string ServerName { get; set; }
        public IList<SummaryItemSiteDetails> SummaryItemDetails { get; set; }
        public int SyncedItems { get; set; }
        public int TotalItems { get; set; }

        public SyncSummaryServer() { }
    }
}
