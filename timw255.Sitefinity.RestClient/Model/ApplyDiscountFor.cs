using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public enum ApplyDiscountFor
    {
        AllCustomers = 1,
        ExistingCustomers = 2,
        NewCustomers = 3,
        WithCouponCode = 4,
        SelectUsersAndRoles = 5
    }
}
