using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public abstract class MediaContent : ContentBase
    {
        public LstringSingleViewModel ApprovalWorkflowState { get; set; }
        public LstringSingleViewModel Author { get; set; }
        public string BlobStorageProvider { get; set; }
        public string Extension { get; set; }
        public Guid? FolderId { get; set; }
        public LstringSingleViewModel ItemDefaultUrl { get; set; }
        public string MediaUrl { get; set; }
        public IEnumerable<string> ThumbnailNames { get; set; }
        public int ThumbnailsVersion { get; set; }
        public string ThumbnailUrl { get; set; }
        public long TotalSize { get; set; }

        public MediaContent() { }
    }
}
