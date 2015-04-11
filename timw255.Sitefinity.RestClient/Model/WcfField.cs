using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfField : FieldViewModel
    {
        public WcfDatabaseMapping DatabaseMapping { get; set; }
        public WcfFieldDefinition Definition { get; set; }
        public string FieldTypeKey { get; set; }

        public WcfField() { }
    }
}
