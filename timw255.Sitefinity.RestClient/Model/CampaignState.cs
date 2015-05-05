using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public enum CampaignState
    {
        Draft,
        PendingSending,
        Sending,
        Scheduled,
        Completed,
        MissingMailingList,
        ABTest,
        CompletedABTest
    }
}
