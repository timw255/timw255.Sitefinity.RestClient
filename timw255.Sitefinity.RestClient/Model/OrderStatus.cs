using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public enum OrderStatus
    {
        Unknown,
        Pending,
        Paid,
        Declined,
        Shipped,
        Authorized,
        Cancelled,
        Deleted,
        Returned
    }
}
