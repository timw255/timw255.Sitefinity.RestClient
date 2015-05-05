using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class OrderDownload : IDynamicFieldsContainer
    {
        public string ApplicationName { get; set; }
        public Guid ContentId { get; set; }
        public Guid Id { get; set; }
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }

        public OrderDownload() { }
    }
}
