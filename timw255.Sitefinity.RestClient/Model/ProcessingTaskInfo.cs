using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ProcessingTaskInfo
    {
        public string AvailableCommand { get; set; }
        public string AvailableCommandTitle { get; set; }
        public string Description { get; set; }
        public string FailureReport { get; set; }
        public string ProgressReport { get; set; }
        public int ProgressStatus { get; set; }
        public string Status { get; set; }
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public LibraryTasks TaskType { get; set; }

        public ProcessingTaskInfo() { }
    }
}
