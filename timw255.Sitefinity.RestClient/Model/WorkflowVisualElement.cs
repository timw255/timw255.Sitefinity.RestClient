using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WorkflowVisualElement
    {
        public string ArgumentDialogName { get; set; }
        public bool ClosesForm { get; set; }
        public string ContentCommandName { get; set; }
        public string CssClass { get; set; }
        public string DecisionType { get; set; }
        public string OperationName { get; set; }
        public int Ordinal { get; set; }
        public bool PersistOnDecision { get; set; }
        public bool RunAsUICommand { get; set; }
        public string Title { get; set; }
        public WorkflowVisualType VisualType { get; set; }
        public string WarningMessage { get; set; }

        public WorkflowVisualElement() { }
    }
}
