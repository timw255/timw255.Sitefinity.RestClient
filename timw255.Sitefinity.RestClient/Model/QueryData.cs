using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class QueryData
    {
        public Guid Id { get; set; }
        public string PersistentTypeName { get; set; }
        public QueryItem[] QueryItems { get; set; }
        public string Title { get; set; }
        public string[] TypeProperties { get; set; }

        public QueryData() { }
    }
}
