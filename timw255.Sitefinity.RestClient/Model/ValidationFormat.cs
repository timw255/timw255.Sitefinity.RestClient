using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public enum ValidationFormat
    {
        None,
        AlphaNumeric,
        Currency,
        EmailAddress,
        Integer,
        InternetUrl,
        NonAlphaNumeric,
        Numeric,
        Percentage,
        USSocialSecurityNumber,
        USZipCode,
        Custom
    }
}
