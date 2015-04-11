using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfControlProperty
    {
        public string CategoryName { get; set; }
        public string CategoryNameSafe { get; set; }
        public string ClientPropertyTypeName { get; set; }
        public string ElementCssClass { get; set; }
        public int InCategoryOrdinal { get; set; }
        public bool IsProxy { get; set; }
        public string ItemTypeName { get; set; }
        public bool NeedsEditor { get; set; }
        public Guid PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyPath { get; set; }
        public string PropertyValue { get; set; }
        public string TypeEditor { get; set; }

        public WcfControlProperty() { }
    }
}
