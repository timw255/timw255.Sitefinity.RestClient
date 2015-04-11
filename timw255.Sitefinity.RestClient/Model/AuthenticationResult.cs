using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public enum AuthenticationResult
    {
        Success = 0,
        UserLimitReached = 1,
        UserNotFound = 2,
        UserLoggedFromDifferentIp = 3,
        SessionExpired = 4,
        UserLoggedOff = 5,
        UserLoggedFromDifferentComputer = 6,
        Unknown = 7,
        NeedAdminRights = 8,
        UserAlreadyLoggedIn = 9,
        UserRevoked = 10,
        WrongCridentials = 101
    }
}
