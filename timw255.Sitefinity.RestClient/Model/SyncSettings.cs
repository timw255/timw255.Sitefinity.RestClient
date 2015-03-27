using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.SiteSync;
using Telerik.Sitefinity.Utilities.Json;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class SyncSettings
    {
        [DataMember]
        public bool IsMultisiteMigration { get; set; }

        [DataMember]
        public bool IsStopRequested { get; set; }

        [DataMember]
        public IDictionary<Guid, int> ProcessedItemsCountPerSite { get; set; }

        [DataMember]
        public string Schedule { get; set; }

        [DataMember]
        public string ServerId { get; set; }

        [DataMember]
        public List<Guid> Sites { get; set; }

        [DataMember]
        public Guid SummaryId { get; set; }

        [DataMember]
        public SiteSyncSiteInfo TargetSite { get; set; }

        [DataMember]
        public int TotalItemsCount { get; set; }

        [DataMember]
        public IDictionary<Guid, int> TotalItemsCountPerSite { get; set; }

        [DataMember]
        public IDictionary<string, string> TypeFilters { get; set; }

        [DataMember]
        public string[] Types { get; set; }

        [DataMember]
        public Guid UserId { get; set; }

        public SyncSettings() { }

        public static SyncSettings Parse(string data)
        {
            return JsonUtility.FromJson<SyncSettings>(data, null);
        }

        public override string ToString()
        {
            return this.ToJson<SyncSettings>(null);
        }
    }
}
