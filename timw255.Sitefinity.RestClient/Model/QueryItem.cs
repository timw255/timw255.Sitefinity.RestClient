using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class QueryItem
    {
        public Condition Condition { get; set; }
        public bool IsGroup { get; set; }
        public string ItemPath { get; set; }
        public string Join { get; set; }
        public string Name { get; set; }
        public int Ordinal { get; set; }
        public string Value { get; set; }

        public QueryItem() { }
    }
}
