using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DynamicContent
    {
        public LstringSingleViewModel ApprovalWorkflowState { get; set; }
        public string Author { get; set; }
        public string[] AvailableLanguages { get; set; }
        public DateTime DateCreated { get; set; }
        public double Distance { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid Id { get; set; }
        public bool IsDeletable { get; set; }
        public bool IsEditable { get; set; }
        public LstringSingleViewModel ItemDefaultUrl { get; set; }
        public DateTime LastModified { get; set; }
        public Guid LastModifiedBy { get; set; }
        public LifecycleInfo Lifecycle { get; set; }
        public Guid OriginalContentId { get; set; }
        public string ProviderName { get; set; }
        public DateTime PublicationDate { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public string StatusDisplayName { get; set; }
        public bool SystemHasChildItems { get; set; }
        public Guid SystemParentId { get; set; }
        public string SystemParentType { get; set; }
        [Obsolete("Use ItemDefaultUrl instead")]
        public string SystemUrl { get; set; }
        public LstringSingleViewModel UrlName { get; set; }

        public DynamicContent() { }
    }
}
