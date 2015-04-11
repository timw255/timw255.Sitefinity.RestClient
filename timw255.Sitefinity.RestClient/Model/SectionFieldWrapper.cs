using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SectionFieldWrapper
    {
        public int AggregateOrdinal { get; set; }
        public Guid Id { get; set; }
        public bool IsExpandedByDefault { get; set; }
        public bool IsSection { get; set; }
        public bool IsTitleDisplayed { get; set; }
        public string Title { get; set; }

        public SectionFieldWrapper() { }
    }
}
