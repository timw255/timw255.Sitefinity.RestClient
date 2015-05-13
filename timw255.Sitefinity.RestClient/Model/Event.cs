using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Event : ContentBase
    {
        public bool AllDayEvent { get; set; }
        public Lstring ApprovalWorkflowState { get; set; }
        public Lstring City { get; set; }
        public Lstring ContactCell { get; set; }
        public string ContactEmail { get; set; }
        public Lstring ContactName { get; set; }
        public Lstring ContactPhone { get; set; }
        public string ContactWeb { get; set; }
        public Lstring Content { get; set; }
        public Lstring Country { get; set; }
        public DateTime? EventEnd { get; set; }
        public double EventEndUtcOffset { get; set; }
        public DateTime EventStart { get; set; }
        public double EventStartUtcOffset { get; set; }
        public bool IsRecurrent { get; set; }
        public Lstring ItemDefaultUrl { get; set; }
        public string Location { get; set; }
        public Guid ParentId { get; set; }
        public string RecurrenceExpression { get; set; }
        public Lstring State { get; set; }
        public Lstring Street { get; set; }
        public Lstring Summary { get; set; }
        public string TimeZoneId { get; set; }

        public Event() { }
    }
}
