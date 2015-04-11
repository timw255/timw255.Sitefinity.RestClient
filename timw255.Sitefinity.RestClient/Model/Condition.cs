using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Condition
    {
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string Operator { get; set; }

        public Condition() { }
    }
}
