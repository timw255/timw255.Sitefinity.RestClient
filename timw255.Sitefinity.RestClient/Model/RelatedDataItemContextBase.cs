using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class RelatedDataItemContextBase<T> : ItemContext<T>
    {
        public ContentLinkChange[] ChangedRelatedData { get; set; }
        public Guid ItemId { get; set; }

        public RelatedDataItemContextBase() { }
    }
}
