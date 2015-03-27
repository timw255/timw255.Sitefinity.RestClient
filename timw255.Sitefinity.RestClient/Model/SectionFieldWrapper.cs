using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.DynamicModules.Builder.Model;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class SectionFieldWrapper
    {
        [DataMember]
        public int AggregateOrdinal { get; set; }

        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public bool IsExpandedByDefault { get; set; }

        [DataMember]
        public bool IsSection { get; set; }

        [DataMember]
        public bool IsTitleDisplayed { get; set; }

        [DataMember]
        public string Title { get; set; }

        public SectionFieldWrapper() { }
    }
}
