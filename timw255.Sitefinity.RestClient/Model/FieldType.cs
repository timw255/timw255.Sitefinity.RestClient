using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public abstract class FieldType
    {
        public LstringSingleViewModel Description { get; set; }
        public string FieldName { get; set; }
        public abstract string FieldTypeTitle { get; set; }
        public Guid Id { get; set; }
        public int PositionInSection { get; set; }
        public bool Required { get; set; }
        public string SectionName { get; set; }
        public LstringSingleViewModel Title { get; set; }

        public FieldType() { }
    }
}
