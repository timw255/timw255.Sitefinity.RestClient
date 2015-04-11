using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class PublishingPointViewModel
    {
        public DateTime DateCreated { get; set; }
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastPublicationDate { get; set; }
        public List<PipeShortData> OutputPipes { get; set; }
        public string Owner { get; set; }
        public string Title { get; set; }

        public PublishingPointViewModel() { }
    }
}
