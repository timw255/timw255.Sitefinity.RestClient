using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [Obsolete("Comments are provided by the CommentService.")]
    public class Comment : ContentBase
    {
        public Lstring AuthorName { get; set; }
        public Guid CommentedItemID { get; set; }
        public string CommentedItemType { get; set; }
        public CommentStatus CommentStatus { get; set; }
        public Lstring Content { get; set; }
        public string Email { get; set; }
        public string IpAddress { get; set; }
        public IList<Guid> ParentGroupIds { get; set; }
        [Obsolete]
        public string ProviderName { get; set; }
        public string Website { get; set; }

        public Comment() { }
    }
}
