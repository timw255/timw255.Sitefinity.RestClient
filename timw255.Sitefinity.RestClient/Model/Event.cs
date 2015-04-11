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
        public LstringSingleViewModel ApprovalWorkflowState { get; set; }
        public LstringSingleViewModel City { get; set; }
        public LstringSingleViewModel ContactCell { get; set; }
        public string ContactEmail { get; set; }
        public LstringSingleViewModel ContactName { get; set; }
        public LstringSingleViewModel ContactPhone { get; set; }
        public string ContactWeb { get; set; }
        public LstringSingleViewModel Content { get; set; }
        public LstringSingleViewModel Country { get; set; }
        public DateTime? EventEnd { get; set; }
        public double EventEndUtcOffset { get; set; }
        public DateTime EventStart { get; set; }
        public double EventStartUtcOffset { get; set; }
        public bool IsRecurrent { get; set; }
        public LstringSingleViewModel ItemDefaultUrl { get; set; }
        public string Location { get; set; }
        public Guid ParentId { get; set; }
        public string RecurrenceExpression { get; set; }
        public LstringSingleViewModel State { get; set; }
        public LstringSingleViewModel Street { get; set; }
        public LstringSingleViewModel Summary { get; set; }
        public string TimeZoneId { get; set; }

        public Event() { }
    }
}
