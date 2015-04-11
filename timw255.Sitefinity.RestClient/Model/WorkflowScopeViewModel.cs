using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WorkflowScopeViewModel
    {
        public string ContentType { get; set; }
        public Guid Id { get; set; }
        public string Language { get; set; }
        public Guid? ParentId { get; set; }
        public string QueryData { get; set; }
        public IList<string> SelectedIds { get; set; }
        public string Title { get; set; }

        public WorkflowScopeViewModel() { }
    }
}
