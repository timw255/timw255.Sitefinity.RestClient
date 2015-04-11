using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ContentTypeSimpleContext
    {
        public string ContentTypeDescription { get; set; }
        public Guid ContentTypeId { get; set; }
        public string ContentTypeTitle { get; set; }

        public ContentTypeSimpleContext() { }
    }
}
