using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WorkflowVisualElementsContext
    {
        public string CommandToExecute { get; set; }
        public WcfApprovalTrackingRecord LastApprovalTrackingRecord { get; set; }
        public string NegativeMessage { get; set; }
        public string OperationName { get; set; }
        public string PositiveMessage { get; set; }
        public string Status { get; set; }

        public WorkflowVisualElementsContext() { }
    }
}
