using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SiteSyncLogEntryViewModel
    {
        public string AdditionalInfo { get; set; }
        public Guid Id { get; set; }
        public string ItemAction { get; set; }
        public string ItemActionTitle { get; set; }
        public string ItemId { get; set; }
        public string Language { get; set; }
        public string ParentTitle { get; set; }
        public string ServerId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }

        public SiteSyncLogEntryViewModel() { }
    }
}
