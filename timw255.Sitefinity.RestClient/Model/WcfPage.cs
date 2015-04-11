using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPage : WcfPageNode
    {
        public DictionaryObjectViewModel Attributes { get; set; }
        public int CacheDuration { get; set; }
        public bool CacheOutput { get; set; }
        public string CodeBehindType { get; set; }
        public bool Crawlable { get; set; }
        public PageCustomFieldsViewModel CustomFields { get; set; }
        public LstringSingleViewModel Description { get; set; }
        public bool DuplicateChildren { get; set; }
        public CanonicalUrlSettings EnableDefaultCanonicalUrl { get; set; }
        public bool EnableViewState { get; set; }
        public string HeadTagContent { get; set; }
        public bool IncludeInSearchIndex { get; set; }
        public bool IncludeInSitemap { get; set; }
        public bool IncludeScriptManager { get; set; }
        public bool IsGroup { get; set; }
        public LstringSingleViewModel Keywords { get; set; }
        public string Language { get; set; }
        public string NavigateUrl { get; set; }
        public string OutputCacheProfile { get; set; }
        public WcfPageNode Parent { get; set; }
        public float Priority { get; set; }
        public bool RequireSsl { get; set; }
        public LstringSingleViewModel SeoTitle { get; set; }
        public bool ShowInNavigation { get; set; }
        public bool SlidingExpiration { get; set; }
        public Guid SourceLanguagePageId { get; set; }
        public Guid TargetSiteId { get; set; }
        public WcfPageTemplate Template { get; set; }
        public string UrlName { get; set; }

        public WcfPage() { }
    }
}
