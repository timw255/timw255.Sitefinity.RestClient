using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ContentTypeTreeItemContext
    {
        public Guid ContentTypeId { get; set; }
        public ContentTypeTreeItemContext[] Items { get; set; }
        public string Text { get; set; }

        public ContentTypeTreeItemContext() { }
    }
}
