using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class OrderStatusHistory : IDynamicFieldsContainer
    {
        public string ApplicationName { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string OrderStatusTitle { get; set; }
        public Guid UserId { get; set; }

        public OrderStatusHistory() { }
    }
}
