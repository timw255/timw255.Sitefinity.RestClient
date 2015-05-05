using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ContentLink
    {
        public string ApplicationName { get; set; }
        public IDictionary<string, string> Attributes { get; set; }
        public bool AvailableForLive { get; set; }
        public bool AvailableForMaster { get; set; }
        public bool AvailableForTemp { get; set; }
        public string ChildItemAdditionalInfo { get; set; }
        public Guid ChildItemId { get; set; }
        public string ChildItemProviderName { get; set; }
        public string ChildItemType { get; set; }
        public string ComponentPropertyName { get; set; }
        public Guid Id { get; set; }
        public bool IsChildDeleted { get; set; }
        public bool IsParentDeleted { get; set; }
        public DateTime LastModified { get; set; }
        public float Ordinal { get; set; }
        public string ParentItemAdditionalInfo { get; set; }
        public Guid ParentItemId { get; set; }
        public string ParentItemProviderName { get; set; }
        public string ParentItemType { get; set; }

        public ContentLink() { }
    }
}
