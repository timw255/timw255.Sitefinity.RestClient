using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class IssueSubscriberViewModel
    {
        public DateTime? DateOpened { get; set; }
        public string DeliveryState { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public Guid SubscriberId { get; set; }

        public IssueSubscriberViewModel() { }
    }
}
