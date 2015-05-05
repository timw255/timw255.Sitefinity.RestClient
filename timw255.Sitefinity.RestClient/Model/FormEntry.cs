using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class FormEntry : IDynamicFieldsContainer, IContent
    {
        public DateTime DateCreated { get; set; }
        public Lstring Description { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid Id { get; set; }
        public string IpAddress { get; set; }
        public string Language { get; set; }
        public Guid Owner { get; set; }
        public DateTime PublicationDate { get; set; }
        public string ReferralCode { get; set; }
        public string SourceSiteDisplayName { get; set; }
        public Guid SourceSiteId { get; set; }
        public string SourceSiteName { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public DateTime SubmittedOn { get; set; }
        public Lstring Title { get; set; }
        public string Username { get; set; }
        public bool Visible { get; set; }

        public FormEntry() { }
    }
}
