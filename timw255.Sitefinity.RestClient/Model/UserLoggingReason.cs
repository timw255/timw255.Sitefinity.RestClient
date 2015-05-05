using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public enum UserLoggingReason
    {
        Success,
        UserLimitReached,
        UserNotFound,
        UserLoggedFromDifferentIp,
        SessionExpired,
        UserLoggedOff,
        UserLoggedFromDifferentComputer,
        Unknown,
        NeedAdminRights,
        UserAlreadyLoggedIn,
        UserRevoked,
        SiteAccessNotAllowed,
        RejectedCustom
    }
}
