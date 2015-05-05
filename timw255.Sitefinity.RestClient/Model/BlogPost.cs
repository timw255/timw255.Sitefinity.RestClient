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
        public LstringSingleViewModel ApprovalWorkflowState { get; set; }
        public LstringSingleViewModel Content { get; set; }
        public LstringSingleViewModel ItemDefaultUrl { get; set; }
        public LstringSingleViewModel Summary { get; set; }

        public BlogPost() { }
    }
}
