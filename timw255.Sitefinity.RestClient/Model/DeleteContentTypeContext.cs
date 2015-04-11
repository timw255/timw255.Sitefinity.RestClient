using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DeleteContentTypeContext
    {
        public DeleteStatus DeleteContentTypeStatus { get; set; }
        public string ErrorMessage { get; set; }

        public DeleteContentTypeContext() { }
    }
}
