using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WorkflowPermissionViewModel
    {
        public string ActionName { get; set; }
        public Guid Id { get; set; }
        public string PrincipalId { get; set; }
        public string PrincipalName { get; set; }
        public WorkflowPrincipalType PrincipalType { get; set; }

        public WorkflowPermissionViewModel() { }
    }
}
