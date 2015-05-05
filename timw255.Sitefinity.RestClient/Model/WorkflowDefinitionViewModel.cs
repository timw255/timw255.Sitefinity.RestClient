using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WorkflowDefinitionViewModel
    {
        public bool AllowAdministratorsToSkipWorkflow { get; set; }
        public DateTime DateCreated { get; set; }
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public string OwnerUserName { get; set; }
        public bool SendFirstLevelEmailNotification { get; set; }
        public bool SendSecondLevelEmailNotification { get; set; }
        public string Title { get; set; }
        public string UIStatus { get; set; }
        public string UIWorkflowType { get; set; }
        public IList<WorkflowPermissionViewModel> WorkflowPermissions { get; set; }
        public IList<WorkflowScopeViewModel> WorkflowScopes { get; set; }
        public WorkflowType WorkflowType { get; set; }

        public WorkflowDefinitionViewModel() { }
    }
}
