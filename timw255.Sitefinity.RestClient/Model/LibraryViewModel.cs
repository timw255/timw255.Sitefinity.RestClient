using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class LibraryViewModel : HierarchicalContentViewModelBase
    {
        public string BlobStorageProvider { get; set; }
        public int Height { get; set; }
        public bool IsManageable { get; set; }
        public DateTime? LastUploadedDate { get; set; }
        public string LibrariesCount { get; set; }
        public string LibraryType { get; set; }
        public string MediaItemsCount { get; set; }
        public bool NeedThumbnailsRegeneration { get; set; }
        public Guid? ParentId { get; set; }
        public WcfScheduledTask ScheduledTaskInfo { get; set; }
        public ProcessingTaskInfo TaskInfo { get; set; }
        public IEnumerable<string> ThumbnailProfiles { get; set; }
        public string ThumbnailUrl { get; set; }
        public int Width { get; set; }

        public LibraryViewModel() { }
    }
}
