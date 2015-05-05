using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace timw255.Sitefinity.RestClient.Model
{
    public sealed class XmlResourceEntry : ResourceEntry
    {
        public DataItemStatus DataStatus { get; set; }
        public override string Description { get; set; }
        public override string Value { get; set; }
        public XElement XmlElement { get; set; }

        public XmlResourceEntry() { }
    }
}
