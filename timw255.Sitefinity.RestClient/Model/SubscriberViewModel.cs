using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SubscriberViewModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public List<MailingListViewModel> Lists { get; set; }
        public string Name { get; set; }
        public string SubscriberReportUrl { get; set; }

        public SubscriberViewModel() { }
    }
}
