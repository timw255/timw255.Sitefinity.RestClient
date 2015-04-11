using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class PresentationData
    {
        public string ApplicationName { get; set; }
        public string Data { get; set; }
        public string DataType { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid Owner { get; set; }
        public string Theme { get; set; }

        public PresentationData() { }
    }
}
