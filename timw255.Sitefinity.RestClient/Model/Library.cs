using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Library : ContentBase
    {
        public string BlobStorageProvider { get; set; }
        public int ClientCacheDuration { get; set; }
        public string ClientCacheProfile { get; set; }
        public override Lstring Description { get; set; }
        public string DownloadSecurityProviderName { get; set; }
        public bool EnableClientCache { get; set; }
        public bool EnableOutputCache { get; set; }
        public LstringSingleViewModel ItemDefaultUrl { get; set; }
        public long MaxItemSize { get; set; }
        public long MaxSize { get; set; }
        public int OutputCacheDuration { get; set; }
        public int OutputCacheMaxSize { get; set; }
        public string OutputCacheProfile { get; set; }
        public bool OutputSlidingExpiration { get; set; }
        public Guid? ParentId { get; set; }
        public Guid RunningTask { get; set; }
        public IList<string> ThumbnailProfiles { get; set; }
        public override Lstring Title { get; set; }
        public override LstringSingleViewModel UrlName { get; set; }
        public bool UseDefaultSettingsForClientCaching { get; set; }
        public bool UseDefaultSettingsForOutputCaching { get; set; }

        public Library() { }
    }
}
