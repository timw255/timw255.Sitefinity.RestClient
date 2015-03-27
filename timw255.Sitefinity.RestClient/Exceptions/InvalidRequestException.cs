using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Exceptions;

namespace timw255.Sitefinity.RestClient.SitefinityClient.Exceptions
{
    public class InvalidRequestException : SitefinityException
    {
        private string message;

        public InvalidRequestException(string message)
            : this(message, null)
        {
        }

        public InvalidRequestException(string message, Exception innerException)
            : base(message, innerException)
        {
            this.message = message + " ";
        }

        public override string Message
        {
            get
            {
                return "The client query is invalid: " + message;
            }
        }
    }
}
