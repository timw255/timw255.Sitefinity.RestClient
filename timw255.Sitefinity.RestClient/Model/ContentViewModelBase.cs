using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public abstract class ContentViewModelBase
    {
        public virtual string Author { get; set; }
        public string[] AvailableLanguages { get; set; }
        public int CommentsCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid? DefaultPageId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Guid Id { get; set; }
        public virtual bool IsDeletable { get; set; }
        public virtual bool IsEditable { get; set; }
        public int ItemsCount { get; set; }
        public WcfApprovalTrackingRecord LastApprovalTrackingRecord { get; set; }
        public WcfContentLifecycleStatus LifecycleStatus { get; set; }
        public Guid? LiveContentId { get; set; }
        public string Owner { get; set; }
        public string ParentUrl { get; set; }
        public string ProviderName { get; set; }
        public DateTime PublicationDate { get; set; }
        public virtual string Status { get; set; }
        public string Title { get; set; }
        public string UIStatus { get; set; }
        public int Version { get; set; }
        public WcfChange VersionInfo { get; set; }
        public IList<WorkflowVisualElement> WorkflowOperations { get; set; }

        public ContentViewModelBase() { }
    }
}
