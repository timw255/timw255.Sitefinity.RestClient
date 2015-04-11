using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPageTemplateContext
    {
        public ContentLinkChange[] ChangedRelatedData { get; set; }
        public PageTemplateViewModel Item { get; set; }
        public string ItemType { get; set; }

        public WcfPageTemplateContext() { }
    }
}
