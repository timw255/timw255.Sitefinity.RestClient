using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class PublishingPointDetailViewModel
    {
        public string AdditionalFields { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public List<WcfPipeSettings> InboundSettings { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastPublicationDate { get; set; }
        public List<WcfPipeSettings> OutboundSettings { get; set; }
        public string Owner { get; set; }
        public string PublishingPointBusinessObjectName { get; set; }
        public List<SimpleDefinitionField> PublishingPointDefinition { get; set; }
        public WcfPipeSettings[] RegisteredInboundPipeSettings { get; set; }
        public WcfPipeSettings[] RegisteredOutboundPipeSettings { get; set; }
        public string Title { get; set; }

        public PublishingPointDetailViewModel() { }
    }
}
