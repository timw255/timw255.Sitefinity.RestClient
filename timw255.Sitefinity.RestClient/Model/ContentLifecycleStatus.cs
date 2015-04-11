using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public enum ContentLifecycleStatus
    {
        Master = 0,
        Temp = 1,
        Live = 2,
        Deleted = 4
    }
}
