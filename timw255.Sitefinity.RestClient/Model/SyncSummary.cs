using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class SyncSummary
    {
        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public int FailedItems { get; set; }

        [DataMember]
        public string[] Servers { get; set; }

        [DataMember]
        public IList<Guid> Sites { get; set; }

        [DataMember]
        public IList<SyncSummaryServer> SummaryServers { get; set; }

        [DataMember]
        public int SyncedItems { get; set; }

        [DataMember]
        public string UserName { get; set; }

        public SyncSummary() { }
    }
}
