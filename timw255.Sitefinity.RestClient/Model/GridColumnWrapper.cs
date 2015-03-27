using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [DataContract]
    public class GridColumnWrapper
    {
        [DataMember]
        public int ColumnOrdinal { get; set; }

        [DataMember]
        public string GridEditorCssClass { get; set; }

        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool ShowInGrid { get; set; }

        [DataMember]
        public string Title { get; set; }

        public GridColumnWrapper() { }
    }
}
