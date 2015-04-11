using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ContentLinkChange
    {
        public string ChildItemAdditionalInfo { get; set; }
        public Guid ChildItemId { get; set; }
        public string ChildItemProviderName { get; set; }
        public string ChildItemType { get; set; }
        public string ComponentPropertyName { get; set; }
        public float Ordinal { get; set; }
        public ContentLinkChangeState State { get; set; }

        public ContentLinkChange() { }
    }
}
