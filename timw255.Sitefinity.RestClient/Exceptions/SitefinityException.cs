using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Exceptions
{
    [Serializable]
    public class SitefinityException : Exception
    {
        public SitefinityException(string message)
            : this(message, null)
        {
        }

        public SitefinityException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
