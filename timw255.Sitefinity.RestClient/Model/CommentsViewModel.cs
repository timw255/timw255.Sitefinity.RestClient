using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CommentsViewModel : ContentViewModelBase
    {
        public override string Author { get; set; }
        public string AuthorName { get; set; }
        public Guid CommentedItemID { get; set; }
        public string CommentedItemType { get; set; }
        public string CommentStatus { get; set; }
        public string CommentStatusText { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public string IpAddress { get; set; }
        public bool IsAuthorComment { get; set; }
        public override bool IsDeletable { get; set; }
        public override bool IsEditable { get; set; }
        public string Website { get; set; }

        public CommentsViewModel() { }
    }
}
