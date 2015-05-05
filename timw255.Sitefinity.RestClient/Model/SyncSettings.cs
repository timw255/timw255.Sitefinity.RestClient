using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SyncSettings
    {
        public bool IsMultisiteMigration { get; set; }
        public bool IsStopRequested { get; set; }
        public IDictionary<Guid, int> ProcessedItemsCountPerSite { get; set; }
        public string Schedule { get; set; }
        public string ServerId { get; set; }
        public List<Guid> Sites { get; set; }
        public Guid SummaryId { get; set; }
        public SiteSyncSiteInfo TargetSite { get; set; }
        public int TotalItemsCount { get; set; }
        public IDictionary<Guid, int> TotalItemsCountPerSite { get; set; }
        public IDictionary<string, string> TypeFilters { get; set; }
        public string[] Types { get; set; }
        public Guid UserId { get; set; }

        public SyncSettings() { }
    }
}
