using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public abstract class ContentBase : IContent
    {
        public bool? AllowComments { get; set; }
        [Obsolete("Not applicable.")]
        public bool? AllowTrackBacks { get; set; }
        [Obsolete("Not applicable. Configuration is available per item type in CommentsModuleConfig.")]
        public bool? ApproveComments { get; set; }
        public string[] AvailableLanguages { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? DefaultPageId { get; set; }
        public virtual Lstring Description { get; set; }
        [Obsolete("Not applicable.")]
        public bool? EmailAuthor { get; set; }
        public virtual DateTime? ExpirationDate { get; set; }
        public Guid Id { get; set; }
        public bool IncludeInSitemap { get; set; }
        public Guid LastModifiedBy { get; set; }
        public Guid OriginalContentId { get; set; }
        public Guid Owner { get; set; }
        [Obsolete("Not applicable. Configuration is available per item type in CommentsModuleConfig.")]
        public PostRights PostRights { get; set; }
        public DateTime PublicationDate { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public virtual Lstring Title { get; set; }
        public ContentUIStatus UIStatus { get; set; }
        public virtual LstringSingleViewModel UrlName { get; set; }
        public int Version { get; set; }
        public int ViewsCount { get; set; }
        public bool Visible { get; set; }
        public uint VotesCount { get; set; }
        public decimal VotesSum { get; set; }

        public ContentBase() { }
    }
}
