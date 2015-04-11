using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class IssueViewModel : CampaignViewModel
    {
        public Guid RootCampaignId { get; set; }
        public string RootCampaignName { get; set; }

        public IssueViewModel() { }
    }
}
