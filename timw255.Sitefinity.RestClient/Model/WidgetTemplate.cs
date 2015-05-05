using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WidgetTemplate
    {
        public string AreaName { get; set; }
        public string Condition { get; set; }
        public string ControlType { get; set; }
        public string DataType { get; set; }
        public string FriendlyControlName { get; set; }
        public Guid Id { get; set; }
        public DtoDateTime LastModified { get; set; }
        public string Name { get; set; }
        public string PresentationData { get; set; }
        public ICollection<DataItemProperty> Properties { get; set; }

        public WidgetTemplate() { }
    }
}
