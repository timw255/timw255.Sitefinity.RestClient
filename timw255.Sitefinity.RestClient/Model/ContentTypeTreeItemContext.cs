using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class ContentTypeTreeItemContext
    {
        [DataMember(Name = "value")]
        public Guid ContentTypeId { get; set; }

        [DataMember(Name = "items")]
        public ContentTypeTreeItemContext[] Items { get; set; }

        public Guid ParentContentTypeId { get; set; }

        [DataMember(Name = "text")]
        public string Text { get; set; }

        public ContentTypeTreeItemContext() { }
    }
}
