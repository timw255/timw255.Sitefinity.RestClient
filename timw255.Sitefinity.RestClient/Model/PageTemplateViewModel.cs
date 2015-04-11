using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class PageTemplateViewModel : WcfPageTemplate
    {
        public Guid Category { get; set; }
        public int ChildTemplatesCount { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool IsEditable { get; set; }
        public string Owner { get; set; }
        public WcfContentLifecycleStatus PageLifecycleStatus { get; set; }
        public int PagesCount { get; set; }
        public string PagesCountString { get; set; }
        public Guid ParentTemplateId { get; set; }
        public string ParentTemplateTitle { get; set; }
        public string ParentTemplateUrl { get; set; }
        public bool ShowInNavigation { get; set; }
        public int SitesCount { get; set; }
        public string Status { get; set; }
        public string StatusText { get; set; }
        public WcfPageTemplate Template { get; set; }
        public Guid TemplateId { get; set; }
        public string TemplatePreviewUrl { get; set; }

        public PageTemplateViewModel() { }
    }
}
