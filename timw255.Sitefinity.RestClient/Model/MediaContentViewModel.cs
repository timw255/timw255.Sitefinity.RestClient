using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MediaContentViewModel : HierarchicalContentViewModelBase, IDynamicFieldsContainer
    {
        public string Description { get; set; }
        public string Extension { get; set; }
        public string FolderTitle { get; set; }
        public bool IsManageable { get; set; }
        public DateTime? LastModified { get; set; }
        public string LibraryTitle { get; set; }
        public string LibraryUrl { get; set; }
        public string MediaUrl { get; set; }
        public float Ordinal { get; set; }
        public Guid OriginalContentId { get; set; }
        public Guid ParentId { get; set; }
        public List<string> ThumbnailNames { get; set; }
        public long TotalSize { get; set; }

        public MediaContentViewModel() { }
    }
}
