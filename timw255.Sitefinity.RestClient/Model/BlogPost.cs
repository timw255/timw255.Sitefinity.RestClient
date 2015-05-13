using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class BlogPost : ContentBase
    {
        public Lstring ApprovalWorkflowState { get; set; }
        public Lstring Content { get; set; }
        public Lstring ItemDefaultUrl { get; set; }
        public Lstring Summary { get; set; }

        public BlogPost() { }
    }
}
