using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ABCampaignGridViewModel
    {
        public string Conclusion { get; set; }
        public DateTime DateEnded { get; set; }
        public DateTime? DateSent { get; set; }
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        public string Name { get; set; }
        public string SampleUsers { get; set; }
        public string TestingNote { get; set; }
        public string Winner { get; set; }

        public ABCampaignGridViewModel() { }
    }
}
