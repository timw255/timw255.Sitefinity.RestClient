using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class PageViewModel : WcfPageNode
    {
        public Guid CurrentTemplateId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsContentEditable { get; set; }
        public bool IsEditable { get; set; }
        public bool IsGroup { get; set; }
        public bool IsHomePage { get; set; }
        public bool IsPersonalized { get; set; }
        public bool IsSubPageCreationAllowed { get; set; }
        public float LevelOrdinal { get; set; }
        public string Location { get; set; }
        public string Owner { get; set; }
        public Guid PageDataId { get; set; }
        public ICollection<KeyValuePair<string, string>> PageEditLanguageUrls { get; set; }
        public string PageEditUrl { get; set; }
        public WcfContentLifecycleStatus PageLifecycleStatus { get; set; }
        public string PageLiveUrl { get; set; }
        public string PageLocation { get; set; }
        public string PageViewUrl { get; set; }
        public string ParentTitlesPath { get; set; }
        public string Status { get; set; }
        public string StatusText { get; set; }
        public WcfPageTemplate Template { get; set; }
        public string UrlName { get; set; }
        public Guid VersioningId { get; set; }
        public bool Visible { get; set; }
        public IList<WorkflowVisualElement> WorkflowOperations { get; set; }

        static PageViewModel() { }
    }
}
