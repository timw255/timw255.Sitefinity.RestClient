using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPageTemplate
    {
        public string[] AvailableLanguages { get; set; }
        public string DuplicateTitle { get; set; }
        public string EditUrl { get; set; }
        public PageTemplateFramework Framework { get; set; }
        public Guid Id { get; set; }
        public string MasterPage { get; set; }
        public bool NotCreateTemplateForMasterPage { get; set; }
        public string RootTaxonType { get; set; }
        public string SourceLanguage { get; set; }
        public Guid SourceLanguagePageId { get; set; }
        public string TemplateIconUrl { get; set; }
        public string TemplateSmallIconUrl { get; set; }
        public string Title { get; set; }

        public WcfPageTemplate() { }
    }
}
