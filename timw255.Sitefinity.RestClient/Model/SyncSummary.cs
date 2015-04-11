using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SyncSummary
    {
        public string Date { get; set; }
        public int FailedItems { get; set; }
        public string[] Servers { get; set; }
        public IList<Guid> Sites { get; set; }
        public IList<SyncSummaryServer> SummaryServers { get; set; }
        public int SyncedItems { get; set; }
        public string UserName { get; set; }

        public SyncSummary() { }
    }
}
