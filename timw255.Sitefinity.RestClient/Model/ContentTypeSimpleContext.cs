using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class ContentTypeSimpleContext
    {
        [DataMember]
        public string ContentTypeDescription { get; set; }

        [DataMember]
        public Guid ContentTypeId { get; set; }

        [DataMember]
        public string ContentTypeTitle { get; set; }

        public ContentTypeSimpleContext() { }
    }
}
