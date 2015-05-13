using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ListItem : ContentBase
    {
        public Lstring ApprovalWorkflowState { get; set; }
        public Lstring Content { get; set; }
        public float Ordinal { get; set; }

        public ListItem() { }
    }
}
